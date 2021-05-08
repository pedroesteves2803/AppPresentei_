namespace AppPresentei_
{
    partial class FrmContainerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainerAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.alterarProdutoToolStripMenuItem,
            this.verProdutosToolStripMenuItem,
            this.minhaEmpresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Empresas";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // alterarProdutoToolStripMenuItem
            // 
            this.alterarProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alterarProdutoToolStripMenuItem.Name = "alterarProdutoToolStripMenuItem";
            this.alterarProdutoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.alterarProdutoToolStripMenuItem.Text = "Usuarios";
            this.alterarProdutoToolStripMenuItem.Click += new System.EventHandler(this.alterarProdutoToolStripMenuItem_Click);
            // 
            // verProdutosToolStripMenuItem
            // 
            this.verProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.verProdutosToolStripMenuItem.Name = "verProdutosToolStripMenuItem";
            this.verProdutosToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.verProdutosToolStripMenuItem.Text = "Ativos";
            this.verProdutosToolStripMenuItem.Click += new System.EventHandler(this.verProdutosToolStripMenuItem_Click);
            // 
            // minhaEmpresaToolStripMenuItem
            // 
            this.minhaEmpresaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minhaEmpresaToolStripMenuItem.Name = "minhaEmpresaToolStripMenuItem";
            this.minhaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.minhaEmpresaToolStripMenuItem.Text = "Desativados";
            this.minhaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.minhaEmpresaToolStripMenuItem_Click);
            // 
            // FrmContainerAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 592);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1130, 639);
            this.Name = "FrmContainerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRESENTEI";
            this.Load += new System.EventHandler(this.FrmContainerAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaEmpresaToolStripMenuItem;
    }
}