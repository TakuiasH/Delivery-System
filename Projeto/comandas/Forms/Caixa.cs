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
    public partial class Caixa : Form
    {
        FileManager configData = new FileManager("config.cfg");
        FileManager entregadorData = new FileManager("entregadores.data");

        public Caixa(float Arrecadado) {
            InitializeComponent();
            time_label.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            float openBalance = configData.getFloat("openingBalance");
            saldoinit_box.Text = openBalance + "";
            init_label.Text = "Saldo Incial: " + openBalance + " R$";
            arrec_label.Text = "Saldo Arrecadado: " + Arrecadado + " R$";
            total_label.Text = "Saldo Total: " + (openBalance + Arrecadado) + " R$";

            if (!configData.getBool("openned")) {
                button1.Text = "Abrir Caixa";
            }
            else
            {
                button1.Text = "Fechar Caixa";
            }
            RenderDeliverymanList();
        }
        void RenderDeliverymanList() {
            List<Deliveryman> deliverymans = new List<Deliveryman>();

            foreach (string dm in entregadorData.getLines()) {
                deliverymans.Add(new Deliveryman(dm, 0));
            }
            foreach (string request in Main.getMain.requests) {
                string[] arg = request.Split('@');
                for(int i = 0; i< deliverymans.Count; i++) {
                    if (arg[11] == deliverymans[i].name) {
                        deliverymans[i].total += 1;
                    }
                }
            }
            deliveryman_label.Text = "";
            foreach(Deliveryman dm in deliverymans) {
                if(dm.total != 0) deliveryman_label.Text += dm.name + ": " + dm.total + Environment.NewLine;
            }
        }
        private void Button1_Click(object sender, EventArgs e) {
            if (!configData.getBool("openned")) {
                if (saldoinit_box.Text == "") { Utils.showMessage("Saldo inicial não pode ficar em branco."); return; }
                configData.set("openned", true);
                configData.set("openingBalance", float.Parse(saldoinit_box.Text));
            } else {
                configData.set("openned", false);
                configData.set("openingBalance", 0);
            }
            
            Close();
        }

        private void Saldoinit_box_TextChanged(object sender, EventArgs e)
        {
            float a; if (!float.TryParse(saldoinit_box.Text, out a)) { saldoinit_box.Clear(); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
