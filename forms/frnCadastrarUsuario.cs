using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EduBank.forms
{
    public partial class frnCadastrarUsuario : Form
    {
        public frnCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblTelefone = new Label();
            lblCpf = new Label();
            lblStatus = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            mTxtTelefone = new MaskedTextBox();
            mTxtCpf = new MaskedTextBox();
            cbBoxStatus = new ComboBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(47, 23);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(47, 84);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(85, 20);
            lblTelefone.TabIndex = 1;
            lblTelefone.Text = "Telefone:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCpf.ForeColor = Color.White;
            lblCpf.Location = new Point(45, 145);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(43, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "Cpf:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(45, 204);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(68, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(45, 264);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(66, 20);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(47, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(203, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(47, 287);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(203, 23);
            txtSenha.TabIndex = 6;
            // 
            // mTxtTelefone
            // 
            mTxtTelefone.Location = new Point(47, 107);
            mTxtTelefone.Mask = "(00) 00000-0000";
            mTxtTelefone.Name = "mTxtTelefone";
            mTxtTelefone.Size = new Size(107, 23);
            mTxtTelefone.TabIndex = 7;
            // 
            // mTxtCpf
            // 
            mTxtCpf.Location = new Point(47, 168);
            mTxtCpf.Mask = "000-000-000.00";
            mTxtCpf.Name = "mTxtCpf";
            mTxtCpf.Size = new Size(107, 23);
            mTxtCpf.TabIndex = 8;
            // 
            // cbBoxStatus
            // 
            cbBoxStatus.FormattingEnabled = true;
            cbBoxStatus.Items.AddRange(new object[] { "Professor", "Aluno" });
            cbBoxStatus.Location = new Point(47, 227);
            cbBoxStatus.Name = "cbBoxStatus";
            cbBoxStatus.Size = new Size(121, 23);
            cbBoxStatus.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.Font = new Font("Century", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(45, 344);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(140, 55);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Font = new Font("Century", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(451, 344);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(90, 43);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // frnCadastrarUsuario
            // 
            BackgroundImage = Properties.Resources.edubank;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(574, 463);
            Controls.Add(btnVoltar);
            Controls.Add(btnCadastrar);
            Controls.Add(cbBoxStatus);
            Controls.Add(mTxtCpf);
            Controls.Add(mTxtTelefone);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblStatus);
            Controls.Add(lblCpf);
            Controls.Add(lblTelefone);
            Controls.Add(lblUsuario);
            Name = "frnCadastrarUsuario";
            Text = "Cadastro Usuario";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
