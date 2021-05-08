namespace AppPresentei_
{
    partial class FrmListarAtivos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.listBoxAtivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(423, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantidades de empresas ativos";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(502, 518);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.ReadOnly = true;
            this.txtQtd.Size = new System.Drawing.Size(100, 22);
            this.txtQtd.TabIndex = 6;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            this.BtnAtualizar.Location = new System.Drawing.Point(483, 458);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(131, 27);
            this.BtnAtualizar.TabIndex = 5;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // listBoxAtivos
            // 
            this.listBoxAtivos.FormattingEnabled = true;
            this.listBoxAtivos.ItemHeight = 16;
            this.listBoxAtivos.Location = new System.Drawing.Point(47, 16);
            this.listBoxAtivos.Name = "listBoxAtivos";
            this.listBoxAtivos.Size = new System.Drawing.Size(1013, 436);
            this.listBoxAtivos.TabIndex = 4;
            // 
            // FrmListarAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1107, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.listBoxAtivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarAtivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmListarAtivos";
            this.Load += new System.EventHandler(this.FrmListarAtivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.ListBox listBoxAtivos;
    }
}