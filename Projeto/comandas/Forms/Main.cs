using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Sockets;
using System.Transactions;
using System.Windows.Forms;
using comandas.Scripts;
using Newtonsoft.Json.Linq;
using SocketIOSharp.Client;
using SocketIOSharp.Packet;

namespace comandas.Forms
{
    public partial class Main : Form
    {
        #region vars
        FileManager requestsData = new FileManager("pedidos", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
        FileManager configData = new FileManager("config.cfg");
        FileManager entregadorData = new FileManager("entregadores.data");
        FileManager clientsData = new FileManager("clients.data");

        public SocketIOClient socket;
        public static Main getMain;
        public List<string> requests = new List<string>();


        public string Atendente;
        public string Impressora;
        int numPedido;
        bool connected;
        float Arrecadado;
        #endregion

        public Main() {
            if (Process.GetProcesses().Count(p => p.ProcessName == Process.GetCurrentProcess().ProcessName) > 3) {Utils.showMessage("O programa já está aberto.");Close();}
            InitializeComponent();
            SetupConfigFile();
            SetupServer();
            getMain = this;
            new Login().ShowDialog();
        }
        void SetupConfigFile() {
            if (!configData.contains("isServer")) configData.set("isServer", false);
            if (!configData.contains("host")) configData.set("host", "localhost");
            if (!configData.contains("port")) configData.set("port", 3000);
            if (!configData.contains("openned")) configData.set("openned", false);
            if (!configData.contains("openingBalance")) configData.set("openingBalance", 0);
            if (configData.contains("printer")) Impressora = configData.getString("printer");
            button2.Enabled = configData.getBool("isServer"); //abrir caixa
            button8.Enabled = configData.getBool("isServer"); //entregadores e taxas
            button3.Enabled = configData.getBool("isServer"); //clientes
            if (configData.getBool("isServer")) Text = "Bom Delivery - " + Atendente + " (Servidor)";
            else Text = "Bom Delivery - " + Atendente + " (Cliente)";
        }
        void SetupServer() {
            socket = new SocketIOClient(SocketIOClient.Scheme.ws, configData.getString("host"), configData.getInt("port"), false, true, false);
            socket.Connect();

            socket.On("socketConnected", socketConnected);

            socket.On("getRequests", getRequests);
            socket.On("newRequest", newRequest);
            socket.On("editRequest", editRequest);
            socket.On("removeRequest", removeRequest);

            socket.On("clearDeliverymanData", clearDeliverymanData);
            socket.On("newDeliveryman", newDeliveryman);

            socket.On("clearClientsData", clearClientsData);
            socket.On("newClient", newClient);

            socket.On("disconnect", disconnect);
            socket.On("disconnected", disconnect);
        }

        #region Socket
        void socketConnected(JToken[] obj) {
            connected = true;

            requests = requestsData.getLines();
            LoadRequests(requests);

            //Serve para se caso o cliente entre antes do servidor, ou o servidor entre antes do cliente, ambos tenham todos os pedidos atualizados.
            if (configData.getBool("isServer")) { //Se for o servidor ele manda os pedidos para os clientes, se não ele pede os pedidos ao servidor.
                foreach (string s in requests) { socket.Emit("newRequest", s); }
                EmitDeliverymanList();
                EmitClientsList();
            }
            else socket.Emit("getRequests");
        } //Quando alguem se conectar incluindo você
        void getRequests(JToken[] obj) {
            connected = true;
            if (configData.getBool("isServer")) foreach (string s in requests) { socket.Emit("newRequest", s); }
        } //Quando um cliente pede os pedidos ao servidor
        void newRequest(JToken[] obj) {
            connected = true;
            requests.Add(obj[0].Value<string>());
            if (configData.getBool("isServer")) { requestsData.write(requests); }
            LoadRequests(requests);
        } //Quando vc receber um novo pediido
        void editRequest(JToken[] obj) { 
            connected = true;
            requests[obj[0].Value<int>("RowIndex")] = obj[0].Value<string>("Request");
            if (configData.getBool("isServer")) { requestsData.write(requests); }
            LoadRequests(requests);
        } //Quando vc recebe a edição de um peiddo
        void removeRequest(JToken[] obj) {
            requests.RemoveAt(obj[0].Value<int>());
            LoadRequests(requests);
        } //Quando vc recebe a remoção de um pedido
        void clearDeliverymanData(JToken[] obj) { 
            entregadorData.write(new List<string>());
        } //Limpa o arquivo da lista dos entregadores
        void newDeliveryman(JToken[] obj) {
            entregadorData.writeline(obj[0].Value<string>());
        } //Adiciona um entregador a lista
        void clearClientsData(JToken[] obj) {
            clientsData.write(new List<string>());
        } //Limpa o arquivo da lista dos entregadores
        void newClient(JToken[] obj) {
            clientsData.writeline(obj[0].Value<string>());
        } //Adiciona um entregador a lista

        void disconnect(JToken[] obj) {
            connected = false;
            requests = requestsData.getLines();
            LoadRequests(requests);
            if (configData.getBool("isServer")) foreach (string s in requests) { socket.Emit("newRequest", s); }
        }
        #endregion

        #region Utils
        public void EmitDeliverymanList() {
            socket.Emit("clearEntregadorData");
            foreach (string s in entregadorData.getLines()) { socket.Emit("newEntregador", s); }
        }
        public void EmitClientsList() {
            socket.Emit("clearClientsData");
            foreach (string s in entregadorData.getLines()) { socket.Emit("newClient", s); }
        }
        public void LoadRequests(List<string> requests) {
            pedidos_list.Rows.Clear();
            for (int i = 0; i < requests.Count; i++) {
                if (requests[i] != "") {
                    bool t = true;
                    string[] args = requests[i].Replace("\\n", Environment.NewLine).Split('@');
                    for (int x = 0; x < args.Length; x++) { if (args[x] == null) t = false; }
                    if (args != null && t == true) pedidos_list.Rows.Add(args);
                }
            }
            float final = 0;
            for (int i = 0; i < pedidos_list.Rows.Count; i++) { if (pedidos_list.Rows[i].Cells[7].Value != null) { try { final += float.Parse(pedidos_list.Rows[i].Cells[7].Value.ToString()); } catch (Exception) { } } }
            total_label.Text = "Total: " + final + " R$";
            numPedido = pedidos_list.Rows.Count;
            Arrecadado = final;
        }
        public void EditRequest(int RowIndex, string request) {
            requests[RowIndex] = request;
            if (configData.getBool("isServer")) { requestsData.write(requests); }
            LoadRequests(requests);

            JObject jb = new JObject();
            jb.Add("RowIndex", RowIndex);
            jb.Add("Request", request);
            socket.Emit("editRequest", jb);
        }
        bool CheckInputs() {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = Impressora;
            if (!printDoc.PrinterSettings.IsValid) { Utils.showMessage("Impressora invalida ou não encontrada. Por favor, selecione outra."); return false; }
            if (!connected) { Utils.showMessage("O servidor não foi encontrado ou não foi conectado."); return false; }
            if (Atendente == "" || Atendente == null) { Utils.showMessage("Por favor, escolha um atendente."); return false; }
            if (Impressora == "" || Impressora == null) { Utils.showMessage("Por favor, escolha uma impressora."); return false; }
            return true;
        }
        #endregion

        #region Buttons
        void Button6_Click(object sender, EventArgs e) { Close(); } //Close
        void Button2_Click(object sender, EventArgs e) {new Caixa(Arrecadado).ShowDialog();} //Abrir Caixa
        void newRequest_btn_Click(object sender, EventArgs e) {
            if (!CheckInputs()) return;
            requests.Add(Atendente.ToCharArray()[0] + "-" + (numPedido+1) + "@@@@@@@@@@");
            LoadRequests(requests);
            socket.Emit("newRequest", Atendente.ToCharArray()[0] + "-" + (numPedido + 1) + "@@@@@@@@@@");
            new Pedido(Atendente.ToCharArray()[0] + "-" + numPedido, pedidos_list.Rows.Count-1).ShowDialog();
        } //Novo pedido
        void Config_Click(object sender, EventArgs e) {
            if (!connected) { Utils.showMessage("O servidor não foi encontrado ou não foi conectado."); return; }
            if (Atendente == "" || Atendente == null) { Utils.showMessage("Por favor, escolha um atendente."); return; }
            new Configs().ShowDialog();
        }//configurações
        void pedidos_list_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (!CheckInputs()) return;
            if (e.RowIndex != -1) {
                string[] args = new string[12];
                for (int i = 0; i < args.Length; i++) {if (pedidos_list.Rows[e.RowIndex].Cells[i].Value != null) args[i] = pedidos_list.Rows[e.RowIndex].Cells[i].Value.ToString();}
                if (args[0] == null || args[0] == "") { Utils.showMessage("Você não pode abrir este pedido pois ele está sem numeração."); return; }
                Pedido form = new Pedido(true, e.RowIndex, args);
                form.ShowDialog();
            }
        }
        void button1_Click(object sender, EventArgs e) {
            new Login().ShowDialog(this);
        } //Bloquear ou trocar usuario
        void Button8_Click(object sender, EventArgs e) {
            new Entregadores().ShowDialog();
        } //Entregadores
        private void button3_Click(object sender, EventArgs e){
            new Clientes().ShowDialog();
        }
        #endregion

    }
}
