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
    public partial class Pagamento : Form
    {
        float total;
        float entregue;
        float troco;
        Pedido form;
        public Pagamento(Pedido pedidoForm, float total)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Dinheiro", "Cartão" });
            comboBox1.SelectedIndex = 0;
            this.total = total;
            form = pedidoForm;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            form.SetStatus("Finalizado");
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            float a; if (!float.TryParse(textBox1.Text, out a)) { textBox1.Clear(); }
            entregue = a;
            troco = entregue - total;
            total_label.Text = "Total: " + total + " R$";
            entregue_label.Text = "Entregue: " + entregue + " R$";
            troco_label.Text = "Troco: " + troco + " R$";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = comboBox1.Text == "Dinheiro";
        }
    }
}
