using comandas.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comandas.Forms
{
    public partial class Clientes : Form
    {
        FileManager clientsData = new FileManager("clients.data");
        List<string> clients = new List<string>();

        public Clientes() {
            InitializeComponent();
            clients = clientsData.getLines();
            LoadList(1, 20);
        }

        private void button2_Click(object sender, EventArgs e) {
            
        }

        public void LoadList(int x, int y) {
            clients = clientsData.getLines();
            clients_list.Rows.Clear();
            if (clients.Count < y) y = clients.Count;
            for (int i = x-1; i < y; i++) {
                if (clients[i] != "") {
                    bool t = true;
                    string[] args = clients[i].Replace("\\n", Environment.NewLine).Split('@');
                    for (int z = 0; z < args.Length; z++) { if (args[z] == null) t = false; }
                    if (args != null && t == true) clients_list.Rows.Add(args);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (clients_list.SelectedRows.Count == 0) {Utils.showMessage("Por favor, selecione um cliente para apagar.");return;}
            List<string> c = clientsData.getLines();
            c.RemoveAt(clients_list.SelectedRows[0].Index);
            clientsData.write(c);
            LoadList(1, 20);
            Main.getMain.EmitClientsList();
        }
    }
}
