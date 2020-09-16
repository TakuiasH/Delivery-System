namespace comandas.Forms
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.saldoinit_box = new System.Windows.Forms.TextBox();
            this.saldo_inicial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.init_label = new System.Windows.Forms.Label();
            this.arrec_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryman_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saldoinit_box
            // 
            this.saldoinit_box.Location = new System.Drawing.Point(9, 75);
            this.saldoinit_box.Name = "saldoinit_box";
            this.saldoinit_box.Size = new System.Drawing.Size(154, 20);
            this.saldoinit_box.TabIndex = 0;
            this.saldoinit_box.TextChanged += new System.EventHandler(this.Saldoinit_box_TextChanged);
            // 
            // saldo_inicial
            // 
            this.saldo_inicial.AutoSize = true;
            this.saldo_inicial.Location = new System.Drawing.Point(6, 59);
            this.saldo_inicial.Name = "saldo_inicial";
            this.saldo_inicial.Size = new System.Drawing.Size(64, 13);
            this.saldo_inicial.TabIndex = 1;
            this.saldo_inicial.Text = "Saldo Inicial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Abrir Caixa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saldo_inicial);
            this.panel1.Controls.Add(this.saldoinit_box);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 345);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // init_label
            // 
            this.init_label.AutoSize = true;
            this.init_label.Location = new System.Drawing.Point(177, 48);
            this.init_label.Name = "init_label";
            this.init_label.Size = new System.Drawing.Size(93, 13);
            this.init_label.TabIndex = 4;
            this.init_label.Text = "Saldo Inicial: 0 R$";
            // 
            // arrec_label
            // 
            this.arrec_label.AutoSize = true;
            this.arrec_label.Location = new System.Drawing.Point(177, 61);
            this.arrec_label.Name = "arrec_label";
            this.arrec_label.Size = new System.Drawing.Size(121, 13);
            this.arrec_label.TabIndex = 5;
            this.arrec_label.Text = "Saldo Arrecadado: 0 R$";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(177, 74);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(90, 13);
            this.total_label.TabIndex = 6;
            this.total_label.Text = "Saldo Total: 0 R$";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.time_label.Location = new System.Drawing.Point(177, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(89, 20);
            this.time_label.TabIndex = 7;
            this.time_label.Text = "28/09/2020";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entregas:";
            // 
            // deliveryman_label
            // 
            this.deliveryman_label.AutoSize = true;
            this.deliveryman_label.Location = new System.Drawing.Point(412, 39);
            this.deliveryman_label.Name = "deliveryman_label";
            this.deliveryman_label.Size = new System.Drawing.Size(65, 13);
            this.deliveryman_label.TabIndex = 9;
            this.deliveryman_label.Text = "Em Breve....";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 341);
            this.Controls.Add(this.deliveryman_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.arrec_label);
            this.Controls.Add(this.init_label);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(661, 380);
            this.MinimumSize = new System.Drawing.Size(661, 380);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saldoinit_box;
        private System.Windows.Forms.Label saldo_inicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label init_label;
        private System.Windows.Forms.Label arrec_label;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label deliveryman_label;
        private System.Windows.Forms.Button button2;
    }
}