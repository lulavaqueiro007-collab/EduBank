namespace EduBank
{
    partial class frmPgInicialDiretor
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
            pnlPaginaInicial = new Panel();
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            porfessorToolStripMenuItem = new ToolStripMenuItem();
            lojaOnlineToolStripMenuItem = new ToolStripMenuItem();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            pormoçõesToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem1 = new ToolStripMenuItem();
            eduBankToolStripMenuItem = new ToolStripMenuItem();
            movimentaçõesToolStripMenuItem = new ToolStripMenuItem();
            pnlPaginaInicial.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPaginaInicial
            // 
            pnlPaginaInicial.BackColor = Color.Transparent;
            pnlPaginaInicial.Controls.Add(menuStrip1);
            pnlPaginaInicial.Location = new Point(0, 12);
            pnlPaginaInicial.Name = "pnlPaginaInicial";
            pnlPaginaInicial.Size = new Size(801, 438);
            pnlPaginaInicial.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, lojaOnlineToolStripMenuItem, eduBankToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, porfessorToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(67, 20);
            cadastrarToolStripMenuItem.Text = "cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.BackColor = Color.Transparent;
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(123, 22);
            alunoToolStripMenuItem.Text = "aluno";
            // 
            // porfessorToolStripMenuItem
            // 
            porfessorToolStripMenuItem.Name = "porfessorToolStripMenuItem";
            porfessorToolStripMenuItem.Size = new Size(123, 22);
            porfessorToolStripMenuItem.Text = "porfessor";
            // 
            // lojaOnlineToolStripMenuItem
            // 
            lojaOnlineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem, pormoçõesToolStripMenuItem, comprasToolStripMenuItem1 });
            lojaOnlineToolStripMenuItem.Name = "lojaOnlineToolStripMenuItem";
            lojaOnlineToolStripMenuItem.Size = new Size(132, 20);
            lojaOnlineToolStripMenuItem.Text = "Historico de compras";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(134, 22);
            catalogoToolStripMenuItem.Text = "catalogo";
            // 
            // pormoçõesToolStripMenuItem
            // 
            pormoçõesToolStripMenuItem.Name = "pormoçõesToolStripMenuItem";
            pormoçõesToolStripMenuItem.Size = new Size(134, 22);
            pormoçõesToolStripMenuItem.Text = "promoções";
            // 
            // comprasToolStripMenuItem1
            // 
            comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            comprasToolStripMenuItem1.Size = new Size(134, 22);
            comprasToolStripMenuItem1.Text = "compras";
            // 
            // eduBankToolStripMenuItem
            // 
            eduBankToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { movimentaçõesToolStripMenuItem });
            eduBankToolStripMenuItem.Name = "eduBankToolStripMenuItem";
            eduBankToolStripMenuItem.Size = new Size(65, 20);
            eduBankToolStripMenuItem.Text = "EduBank";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            movimentaçõesToolStripMenuItem.Size = new Size(159, 22);
            movimentaçõesToolStripMenuItem.Text = "movimentações";
            // 
            // frmPgInicialDiretor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.edubank;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPaginaInicial);
            MainMenuStrip = menuStrip1;
            Name = "frmPgInicialDiretor";
            Text = "Pagina inicial diretor";
            pnlPaginaInicial.ResumeLayout(false);
            pnlPaginaInicial.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPaginaInicial;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem porfessorToolStripMenuItem;
        private ToolStripMenuItem lojaOnlineToolStripMenuItem;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem pormoçõesToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem1;
        private ToolStripMenuItem eduBankToolStripMenuItem;
        private ToolStripMenuItem movimentaçõesToolStripMenuItem;
    }
}