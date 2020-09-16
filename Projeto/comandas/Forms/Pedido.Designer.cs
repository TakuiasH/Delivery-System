namespace comandas.Forms
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.status_cbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bairro_cbox = new System.Windows.Forms.TextBox();
            this.total_box = new System.Windows.Forms.TextBox();
            this.imprimir_btn = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.pedido_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.obs_box = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ref_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endereco_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tel_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.entregador_cbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // status_cbox
            // 
            this.status_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_cbox.FormattingEnabled = true;
            this.status_cbox.Location = new System.Drawing.Point(546, 417);
            this.status_cbox.Name = "status_cbox";
            this.status_cbox.Size = new System.Drawing.Size(244, 21);
            this.status_cbox.TabIndex = 66;
            this.status_cbox.SelectedIndexChanged += new System.EventHandler(this.status_cbox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(543, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Entregador";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(543, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Status";
            // 
            // bairro_cbox
            // 
            this.bairro_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bairro_cbox.Location = new System.Drawing.Point(546, 310);
            this.bairro_cbox.Name = "bairro_cbox";
            this.bairro_cbox.Size = new System.Drawing.Size(244, 20);
            this.bairro_cbox.TabIndex = 60;
            // 
            // total_box
            // 
            this.total_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_box.Location = new System.Drawing.Point(12, 536);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(96, 20);
            this.total_box.TabIndex = 61;
            this.total_box.TextChanged += new System.EventHandler(this.total_box_TextChanged);
            // 
            // imprimir_btn
            // 
            this.imprimir_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimir_btn.Location = new System.Drawing.Point(670, 523);
            this.imprimir_btn.Name = "imprimir_btn";
            this.imprimir_btn.Size = new System.Drawing.Size(120, 35);
            this.imprimir_btn.TabIndex = 63;
            this.imprimir_btn.Text = "Imprimir";
            this.imprimir_btn.UseVisualStyleBackColor = true;
            this.imprimir_btn.Click += new System.EventHandler(this.imprimir_btn_Click);
            // 
            // total_label
            // 
            this.total_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(9, 520);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(34, 13);
            this.total_label.TabIndex = 75;
            this.total_label.Text = "Total:";
            // 
            // id_label
            // 
            this.id_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id_label.AutoSize = true;
            this.id_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.id_label.Location = new System.Drawing.Point(12, 10);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(62, 13);
            this.id_label.TabIndex = 74;
            this.id_label.Text = "Pedido: A-1";
            // 
            // pedido_box
            // 
            this.pedido_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pedido_box.Location = new System.Drawing.Point(15, 26);
            this.pedido_box.Multiline = true;
            this.pedido_box.Name = "pedido_box";
            this.pedido_box.Size = new System.Drawing.Size(519, 491);
            this.pedido_box.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(543, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Observações";
            // 
            // obs_box
            // 
            this.obs_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obs_box.Location = new System.Drawing.Point(546, 351);
            this.obs_box.Multiline = true;
            this.obs_box.Name = "obs_box";
            this.obs_box.Size = new System.Drawing.Size(244, 47);
            this.obs_box.TabIndex = 62;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Location = new System.Drawing.Point(420, 523);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(120, 35);
            this.cancel_btn.TabIndex = 65;
            this.cancel_btn.Text = "Voltar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Location = new System.Drawing.Point(546, 523);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 35);
            this.add_btn.TabIndex = 64;
            this.add_btn.Text = "Adicionar";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(543, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(543, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Referencia";
            // 
            // ref_box
            // 
            this.ref_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ref_box.Location = new System.Drawing.Point(546, 196);
            this.ref_box.Multiline = true;
            this.ref_box.Name = "ref_box";
            this.ref_box.Size = new System.Drawing.Size(244, 95);
            this.ref_box.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(543, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Endereço";
            // 
            // endereco_box
            // 
            this.endereco_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endereco_box.Location = new System.Drawing.Point(546, 108);
            this.endereco_box.Multiline = true;
            this.endereco_box.Name = "endereco_box";
            this.endereco_box.Size = new System.Drawing.Size(244, 69);
            this.endereco_box.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(543, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Telefone";
            // 
            // tel_box
            // 
            this.tel_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tel_box.Location = new System.Drawing.Point(546, 67);
            this.tel_box.Name = "tel_box";
            this.tel_box.Size = new System.Drawing.Size(244, 20);
            this.tel_box.TabIndex = 57;
            this.tel_box.TextChanged += new System.EventHandler(this.tel_box_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(543, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nome";
            // 
            // name_box
            // 
            this.name_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_box.Location = new System.Drawing.Point(546, 26);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(244, 20);
            this.name_box.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(670, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 78;
            this.button1.Text = "Pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // entregador_cbox
            // 
            this.entregador_cbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entregador_cbox.FormattingEnabled = true;
            this.entregador_cbox.Location = new System.Drawing.Point(546, 458);
            this.entregador_cbox.Name = "entregador_cbox";
            this.entregador_cbox.Size = new System.Drawing.Size(244, 21);
            this.entregador_cbox.TabIndex = 79;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.entregador_cbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_cbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bairro_cbox);
            this.Controls.Add(this.total_box);
            this.Controls.Add(this.imprimir_btn);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.pedido_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.obs_box);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ref_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endereco_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tel_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 600);
            this.Name = "Pedido";
            this.Text = "Novo Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox status_cbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bairro_cbox;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Button imprimir_btn;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox pedido_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox obs_box;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ref_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endereco_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tel_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox entregador_cbox;
    }
}