
namespace Bitchain
{
    partial class FormAlterarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblAlterarSenhaCliente = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(293, 267);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(222, 26);
            this.dtpNascimento.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label6.Location = new System.Drawing.Point(288, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label4.Location = new System.Drawing.Point(289, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label5.Location = new System.Drawing.Point(289, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.Location = new System.Drawing.Point(294, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 26);
            this.txtEmail.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNome.Location = new System.Drawing.Point(294, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 26);
            this.txtNome.TabIndex = 41;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arial Black", 12F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(420, 490);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(159, 45);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Black", 12F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(239, 490);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(159, 45);
            this.btnCadastrar.TabIndex = 39;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label2.Location = new System.Drawing.Point(288, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Usuario: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(293, 351);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 26);
            this.txtUsuario.TabIndex = 35;
            // 
            // lblAlterarSenhaCliente
            // 
            this.lblAlterarSenhaCliente.AutoSize = true;
            this.lblAlterarSenhaCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAlterarSenhaCliente.Location = new System.Drawing.Point(345, 418);
            this.lblAlterarSenhaCliente.Name = "lblAlterarSenhaCliente";
            this.lblAlterarSenhaCliente.Size = new System.Drawing.Size(103, 18);
            this.lblAlterarSenhaCliente.TabIndex = 47;
            this.lblAlterarSenhaCliente.TabStop = true;
            this.lblAlterarSenhaCliente.Text = "Alterar Senha";
            this.lblAlterarSenhaCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAlterarSenhaCliente_LinkClicked);
            // 
            // FormAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lblAlterarSenhaCliente);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAlterarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitchain - Alterar Cliente";
            this.Load += new System.EventHandler(this.FormAlterarCliente_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel lblAlterarSenhaCliente;
    }
}