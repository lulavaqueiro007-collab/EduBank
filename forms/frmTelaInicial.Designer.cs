namespace EduBank
{
    partial class FrmEduBank
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBoxLoging = new GroupBox();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            gBoxLoging.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxLoging
            // 
            gBoxLoging.BackColor = Color.Transparent;
            gBoxLoging.Controls.Add(btnEntrar);
            gBoxLoging.Controls.Add(btnCadastrar);
            gBoxLoging.Controls.Add(txtSenha);
            gBoxLoging.Controls.Add(txtLogin);
            gBoxLoging.Controls.Add(lblSenha);
            gBoxLoging.Controls.Add(lblUsuario);
            gBoxLoging.Location = new Point(12, 60);
            gBoxLoging.Name = "gBoxLoging";
            gBoxLoging.Size = new Size(328, 378);
            gBoxLoging.TabIndex = 0;
            gBoxLoging.TabStop = false;
            gBoxLoging.Text = "loging";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Red;
            btnEntrar.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(202, 289);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 52);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Blue;
            btnCadastrar.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(6, 289);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(120, 52);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(183, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(6, 128);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(183, 23);
            txtLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(6, 170);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 19);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(6, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // FrmEduBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.edubank;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxLoging);
            Name = "FrmEduBank";
            Text = "EduBank";
            gBoxLoging.ResumeLayout(false);
            gBoxLoging.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxLoging;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnEntrar;
        private Button btnCadastrar;
    }
}
