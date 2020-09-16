using comandas.Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace comandas.Forms
{
    public partial class Pedido : Form
    {
        string ID = "";
        string Iniciado = "";
        int RowIndex = 0;
        bool Added = false;
        string TotalText = "0";
        bool Canceled;
        FileManager entregadorData = new FileManager("entregadores.data");

        public Pedido(string ID, int RowIndex) {InitializeComponent();this.ID = ID; this.RowIndex = RowIndex; Setup(); }
        public Pedido(bool Added, int RowIndex, string[] Args){InitializeComponent();this.Added = Added; this.RowIndex = RowIndex; LoadRequest(Args); Setup(); }


        void Setup() {
            if (!Added) add_btn.Text = "Adicionar";
            else add_btn.Text = "Editar";

            status_cbox.Items.AddRange(new string[] { "Iniciado", "Saiu para entrega", "Finalizado", "Cancelado" });
            status_cbox.SelectedIndex = 0;
            entregador_cbox.Items.Add(" ");
            foreach (string s in entregadorData.getLines()) { entregador_cbox.Items.Add(s); }

            id_label.Text = ID;
        }

        void LoadRequest(string[] Args) {
            ID = Args[0];
            Iniciado = Args[1];
            name_box.Text = Args[2];
            tel_box.Text = Args[3];
            endereco_box.Text = Args[4];
            bairro_cbox.Text = Args[5];
            status_cbox.Text = Args[6];
            total_box.Text = Args[7];
            TotalText = Args[7];
            pedido_box.Text = Args[8];
            obs_box.Text = Args[9];
            ref_box.Text = Args[10];
            entregador_cbox.Text = Args[11];
        }
        bool CheckInputs(bool sM) {
            if (name_box.Text == "") { if(sM) Utils.showMessage("Nome não pode ficar em branco."); return false; }
            if (pedido_box.Text == "") { if (sM) Utils.showMessage("Pedido não pode ficar em branco."); return false; }
            if (total_box.Text == "") { if (sM) Utils.showMessage("Total não pode ficar em branco."); return false; }
            if (status_cbox.Text == "") { if (sM) Utils.showMessage("Status não pode ficar em branco."); return false; }
            return true;
        }

        FileManager clientsData = new FileManager("clients.data");
        void SetClient(string telefone, string clientString) {
            int result = ClientExist(telefone);
            if (result == -1) {
                clientsData.writeline(clientString);
            } else {
                List<string> lines = clientsData.getLines();
                lines[result] = clientString;
                clientsData.write(lines);
            }
            Main.getMain.EmitClientsList();
        }
        int ClientExist(string telefone) {
            List<string> lines = clientsData.getLines();
            for(int i = 0; i < lines.Count; i++) {
                string[] args = lines[i].Split('@');
                if (args[2] == telefone) {
                    return i;
                }
            }
            return -1;
        }
        bool SetRequest() {
            if (!CheckInputs(true)) return false;
            if (Iniciado == "") Iniciado = DateTime.Now.ToString();
            string clienteString = "";
            clienteString += ((clientsData.getLines().Count + 1) + "@").Replace(Environment.NewLine, "\\n");
            clienteString += (name_box.Text + "@").Replace(Environment.NewLine, "\\n");
            clienteString += (tel_box.Text + "@").Replace(Environment.NewLine, "\\n");
            clienteString += (endereco_box.Text + "@").Replace(Environment.NewLine, "\\n");
            clienteString += (bairro_cbox.Text + "@").Replace(Environment.NewLine, "\\n");
            clienteString += (ref_box.Text).Replace(Environment.NewLine, "\\n");
            SetClient(tel_box.Text, clienteString);
            string final = "";
            final += (ID + "@").Replace(Environment.NewLine, "\\n");
            final += (Iniciado + "@").Replace(Environment.NewLine, "\\n");
            final += (name_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (tel_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (endereco_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (bairro_cbox.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (status_cbox.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (total_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (pedido_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (obs_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (ref_box.Text + "@").Replace(Environment.NewLine, "\\n");
            final += (entregador_cbox.Text).Replace(Environment.NewLine, "\\n");
            Main.getMain.EditRequest(RowIndex, final);


            return true;
        }

        //------------------BUTTONS-----------------//
        private void total_box_TextChanged(object sender, EventArgs e) { float a; if (!float.TryParse(total_box.Text, out a)) { total_box.Clear(); } }
        private void cancel_btn_Click(object sender, EventArgs e) { Canceled = true;  Close(); }
        private void add_btn_Click(object sender, EventArgs e) { if (!SetRequest()) return; Close(); }
        private void imprimir_btn_Click(object sender, EventArgs e) {
            if (!SetRequest()) return;
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = Main.getMain.Impressora;
            printDoc.DocumentName = "Cupom";
            if (!printDoc.PrinterSettings.IsValid) Utils.showMessage("Impressora não encontrada");
            printDoc.PrintPage += new PrintPageEventHandler(PreparePage);
            printDoc.Print();
            Close();
        }

        //---------------------PRINTER---------------------//
        public void PreparePage(object sender, PrintPageEventArgs ev)
        {
            Font titleFont = new Font("Segoe UI", 12f, FontStyle.Bold);
            Font pdvFont = new Font("Segoe UI", 10f, FontStyle.Regular);
            Font pdv2Font = new Font("Segoe UI", 11f, FontStyle.Regular);
            float height = 1f;
            height += Utils.DrawLine(" Aki kiE Pizzaria e Retaurante", height, titleFont, ev);
            height += Utils.DrawLine("CNPJ: 27.801.763/0001-98 I.E.", height, titleFont, ev);
            height += Utils.DrawLine("-----------------------------------", height, titleFont, ev);
            height += Utils.DrawLine("Impresso em: " + DateTime.Now, height, pdvFont, ev);
            height += Utils.DrawLine("Número: " + ID, height, pdvFont, ev);
            height += Utils.DrawLine("          -", height, titleFont, ev);
            height += Utils.DrawLine("Cliente: " + name_box.Text, height, pdvFont, ev);
            height += Utils.DrawLine("Telefone: " + tel_box.Text, height, pdvFont, ev);
            height += Utils.DrawLine("          -", height, titleFont, ev);
            height += Utils.DrawLine("Endereço: " + endereco_box.Text, height, pdvFont, ev);
            height += Utils.DrawLine("Referencia: " + ref_box.Text, height, pdvFont, ev);
            height += Utils.DrawLine("Bairro: " + bairro_cbox.Text, height, pdvFont, ev);
            height += Utils.DrawLine("-----------------------------------", height, titleFont, ev);
            height += Utils.DrawLine("Pedido: " + pedido_box.Text, height, pdvFont, ev);
            height += Utils.DrawLine("Total: " + total_box.Text + " R$", height, pdvFont, ev);
            height += Utils.DrawLine("Atendente: " + Main.getMain.Atendente, height, pdvFont, ev);
            height += Utils.DrawLine("          -", height, titleFont, ev);
            height += Utils.DrawLine("Observação: " + obs_box.Text, height, pdv2Font, ev);
            height += Utils.DrawLine("Entregador: " + entregador_cbox.Text, height, pdv2Font, ev);
            height += Utils.DrawLine("-----------------------------------", height, titleFont, ev);
            Utils.DrawLine("  Bom Delivery 0.1 Alpha", height, titleFont, ev);
        }

        private void status_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (status_cbox.Text == "Cancelado") total_box.Text = "0";
            else total_box.Text = TotalText;
        }

        private void closing(object sender, FormClosingEventArgs e) {
            if(!Canceled) if(CheckInputs(false)) if (!SetRequest()){ e.Cancel = true; return; }

            if (!CheckInputs(false)) {
                Main.getMain.requests.RemoveAt(RowIndex);
                Main.getMain.LoadRequests(Main.getMain.requests);

                Main.getMain.socket.Emit("removeRequest", RowIndex);
            }
        }
        public void SetStatus(string arg) {
            status_cbox.Text = arg;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Added) new Pagamento(this, float.Parse(total_box.Text)).ShowDialog();
            else Utils.showMessage("Você precisa adicionar o pedido primeiro.");
        }

        private void tel_box_TextChanged(object sender, EventArgs e) {

            if (tel_box.Text.Length >= 8) {
                int result = ClientExist(tel_box.Text);
                if (result != -1) {
                    string[] client = clientsData.getLines()[result].Replace("\\n", Environment.NewLine).Split('@');
                    name_box.Text = client[1];
                    tel_box.Text = client[2];
                    endereco_box.Text = client[3];
                    bairro_cbox.Text = client[4];
                    ref_box.Text = client[5];
                }   
            }
        }
    }
}
