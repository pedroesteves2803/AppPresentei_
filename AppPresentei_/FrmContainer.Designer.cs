namespace AppPresentei_
{
    partial class FrmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // alterarProdutoToolStripMenuItem
            // 
            this.alterarProdutoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.alterarProdutoToolStripMenuItem.Name = "alterarProdutoToolStripMenuItem";
            this.alterarProdutoToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.alterarProdutoToolStripMenuItem.Text = "Alterar produto";
            this.alterarProdutoToolStripMenuItem.Click += new System.EventHandler(this.alterarProdutoToolStripMenuItem_Click);
            // 
            // verProdutosToolStripMenuItem
            // 
            this.verProdutosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.verProdutosToolStripMenuItem.Name = "verProdutosToolStripMenuItem";
            this.verProdutosToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.verProdutosToolStripMenuItem.Text = "Ver produtos";
            this.verProdutosToolStripMenuItem.Click += new System.EventHandler(this.verProdutosToolStripMenuItem_Click);
            // 
            // minhaEmpresaToolStripMenuItem
            // 
            this.minhaEmpresaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minhaEmpresaToolStripMenuItem.Name = "minhaEmpresaToolStripMenuItem";
            this.minhaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.minhaEmpresaToolStripMenuItem.Text = "Minha empresa";
            this.minhaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.minhaEmpresaToolStripMenuItem_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(2)))), ((int)(((byte)(4)))));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(934, 0);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 28);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1009, 483);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1069, 535);
            this.Name = "FrmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRESENTEI";
            this.Load += new System.EventHandler(this.FrmContainer_Load);
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
        private System.Windows.Forms.Button BtnSair;
    }
}