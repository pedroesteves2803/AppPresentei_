namespace AppPresentei_
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnAfiliado = new System.Windows.Forms.Button();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAfiliado
            // 
            this.BtnAfiliado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            resources.ApplyResources(this.BtnAfiliado, "BtnAfiliado");
            this.BtnAfiliado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAfiliado.Name = "BtnAfiliado";
            this.BtnAfiliado.UseVisualStyleBackColor = false;
            this.BtnAfiliado.Click += new System.EventHandler(this.BtnAfiliado_Click);
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            resources.ApplyResources(this.BtnLogar, "BtnLogar");
            this.BtnLogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Name = "label1";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.BtnAfiliado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPrincipal";
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAfiliado;
        private System.Windows.Forms.Button BtnLogar;
        private System.Windows.Forms.Label label1;
    }
}

