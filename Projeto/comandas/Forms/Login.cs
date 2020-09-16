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
    public partial class Login : Form
    {
        public Login() {
            InitializeComponent();
            atendente_box.Items.AddRange(new string[6] { "Arthur", "Flavia", "Heitor", "Fabricio", "Adriana", "Thiago" });
            atendente_box.SelectedIndex = 0;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void join_btn_Click(object sender, EventArgs e) {
            Close();
        }

        private void closing(object sender, FormClosingEventArgs e) {
            if (atendente_box.Text == "") { e.Cancel = true; Utils.showMessage("Por favor, escolha um atendente.");  return; }
            Main.getMain.Atendente = atendente_box.Text;
        }
    }
}
