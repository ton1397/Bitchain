
namespace Bitchain
{
    partial class FormAlterarSenhaCliente
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarSenhaNova = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Senha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnVoltar.Font = new System.Drawing.Font("Arial Black", 12F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(256, 328);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(159, 45);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Black", 12F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(91, 328);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(159, 45);
            this.btnCadastrar.TabIndex = 41;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label4.Location = new System.Drawing.Point(130, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Confirmar nova senha: ";
            // 
            // txtConfirmarSenhaNova
            // 
            this.txtConfirmarSenhaNova.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConfirmarSenhaNova.Font = new System.Drawing.Font("Arial", 12F);
            this.txtConfirmarSenhaNova.Location = new System.Drawing.Point(135, 212);
            this.txtConfirmarSenhaNova.Name = "txtConfirmarSenhaNova";
            this.txtConfirmarSenhaNova.PasswordChar = '*';
            this.txtConfirmarSenhaNova.Size = new System.Drawing.Size(221, 26);
            this.txtConfirmarSenhaNova.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label3.Location = new System.Drawing.Point(131, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nova senha: ";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenhaNova.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSenhaNova.Location = new System.Drawing.Point(136, 152);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(221, 26);
            this.txtSenhaNova.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 79);
            this.panel1.TabIndex = 34;
            // 
            // FormAlterarSenhaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(512, 385);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmarSenhaNova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAlterarSenhaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitchain - Alterar Senha Cliente";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarSenhaNova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Panel panel1;
    }
}