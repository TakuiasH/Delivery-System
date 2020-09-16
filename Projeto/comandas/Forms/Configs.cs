using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Printing;
using comandas.Scripts;

namespace comandas.Forms
{
    public partial class Configs : Form
    {
        FileManager configData = new FileManager("config.cfg");

        public Configs() {
            InitializeComponent();
            foreach (var printer in PrinterSettings.InstalledPrinters) { impressora_box.Items.Add(printer); }
            impressora_box.SelectedIndex = 0;
            MaximizeBox = false;
            MinimizeBox = false;
            if (configData.contains("printer")) impressora_box.Text = configData.getString("printer");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void closing(object sender, FormClosingEventArgs e)
        {
            if (impressora_box.Text == "") { e.Cancel = true; Utils.showMessage("Por favor, escolha uma impressora."); return; }
            configData.set("printer", impressora_box.Text);
            Main.getMain.Impressora = impressora_box.Text;
        }
    }
}
