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
    public partial class Entregadores : Form
    {
        FileManager entregadorData = new FileManager("entregadores.data");

        public Entregadores()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            foreach(string s in entregadorData.getLines()) {listBox1.Items.Add(s);}

        }

        private void Button1_Click(object sender, EventArgs e) {
            //add
            listBox1.Items.Add(textBox1.Text);
            List<string> l = new List<string>();
            foreach(string s in listBox1.Items){l.Add(s);}
            entregadorData.write(l);
            Main.getMain.EmitDeliverymanList();
        }

        private void Button2_Click(object sender, EventArgs e) {
            if(listBox1.SelectedIndex == -1){ Utils.showMessage("Por favor, Selecione um entregador."); return; }
            //remove
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            List<string> l = new List<string>();
            foreach (string s in listBox1.Items) { l.Add(s); }
            entregadorData.write(l);
            Main.getMain.EmitDeliverymanList();
        }

        private void Button3_Click(object sender, EventArgs e){Close();}
    }
}
