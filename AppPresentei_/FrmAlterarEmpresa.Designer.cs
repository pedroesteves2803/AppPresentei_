namespace AppPresentei_
{
    partial class FrmAlterarEmpresa
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
            this.label5 = new System.Windows.Forms.Label();
            this.CmbNomeCatao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.Label();
            this.txtSenhaAntiga = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.BtnDesativar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(315, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nome cartão";
            // 
            // CmbNomeCatao
            // 
            this.CmbNomeCatao.FormattingEnabled = true;
            this.CmbNomeCatao.Items.AddRange(new object[] {
            "Santader",
            "Elo"});
            this.CmbNomeCatao.Location = new System.Drawing.Point(438, 264);
            this.CmbNomeCatao.Name = "CmbNomeCatao";
            this.CmbNomeCatao.Size = new System.Drawing.Size(225, 24);
            this.CmbNomeCatao.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(358, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Digitos";
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(438, 330);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(225, 22);
            this.txtDigito.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(300, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero cartão";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(438, 298);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(225, 22);
            this.txtNumero.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(314, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Senha antiga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(367, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "CNPJ";
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.AutoSize = true;
            this.NomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NomeEmpresa.Location = new System.Drawing.Point(295, 136);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(125, 20);
            this.NomeEmpresa.TabIndex = 17;
            this.NomeEmpresa.Text = "Nome Empresa";
            // 
            // txtSenhaAntiga
            // 
            this.txtSenhaAntiga.Location = new System.Drawing.Point(438, 200);
            this.txtSenhaAntiga.Name = "txtSenhaAntiga";
            this.txtSenhaAntiga.Size = new System.Drawing.Size(225, 22);
            this.txtSenhaAntiga.TabIndex = 16;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(438, 168);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(225, 22);
            this.txtCnpj.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(438, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 22);
            this.txtNome.TabIndex = 14;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAlterar.Location = new System.Drawing.Point(451, 358);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(191, 37);
            this.BtnAlterar.TabIndex = 13;
            this.BtnAlterar.Text = "Atualizar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(324, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Senha nova";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(438, 232);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(225, 22);
            this.txtSenhaNova.TabIndex = 26;
            // 
            // BtnDesativar
            // 
            this.BtnDesativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            this.BtnDesativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesativar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDesativar.Location = new System.Drawing.Point(451, 411);
            this.BtnDesativar.Name = "BtnDesativar";
            this.BtnDesativar.Size = new System.Drawing.Size(191, 37);
            this.BtnDesativar.TabIndex = 28;
            this.BtnDesativar.Text = "Desativar conta";
            this.BtnDesativar.UseVisualStyleBackColor = false;
            this.BtnDesativar.Click += new System.EventHandler(this.BtnDesativar_Click);
            // 
            // FrmAlterarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1068, 534);
            this.ControlBox = false;
            this.Controls.Add(this.BtnDesativar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbNomeCatao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.txtSenhaAntiga);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.BtnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarEmpresa";
            this.Text = "FrmAlterarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbNomeCatao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDigito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomeEmpresa;
        private System.Windows.Forms.TextBox txtSenhaAntiga;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Button BtnDesativar;
    }
}