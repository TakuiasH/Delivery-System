namespace comandas.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.atendente_box = new System.Windows.Forms.ComboBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Atendente";
            // 
            // atendente_box
            // 
            this.atendente_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.atendente_box.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.atendente_box.FormattingEnabled = true;
            this.atendente_box.Location = new System.Drawing.Point(15, 64);
            this.atendente_box.Name = "atendente_box";
            this.atendente_box.Size = new System.Drawing.Size(300, 21);
            this.atendente_box.TabIndex = 44;
            // 
            // join_btn
            // 
            this.join_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.join_btn.Location = new System.Drawing.Point(15, 117);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(300, 48);
            this.join_btn.TabIndex = 0;
            this.join_btn.Text = "Entrar";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 177);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atendente_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(343, 215);
            this.MinimumSize = new System.Drawing.Size(343, 215);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox atendente_box;
        private System.Windows.Forms.Button join_btn;
    }
}