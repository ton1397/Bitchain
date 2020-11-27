
namespace Bitchain
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.lblMinhaConta = new System.Windows.Forms.LinkLabel();
            this.lblSair = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpaBusca = new System.Windows.Forms.Button();
            this.cmbTipoBusca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bitchainDataSet = new Bitchain.BitchainDataSet();
            this.bitchainDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitchainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitchainDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 79);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(544, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(470, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Olá,";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Black", 18F);
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNome.Location = new System.Drawing.Point(538, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 33);
            this.lblNome.TabIndex = 4;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(1188, 729);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "v1.0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnCadCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadCliente.Location = new System.Drawing.Point(760, 81);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(126, 46);
            this.btnCadCliente.TabIndex = 8;
            this.btnCadCliente.Text = "Cadastrar";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(17, 29);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(178, 56);
            this.btnGerarRelatorio.TabIndex = 9;
            this.btnGerarRelatorio.Text = "Gerar Relatórios";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // lblMinhaConta
            // 
            this.lblMinhaConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinhaConta.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMinhaConta.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMinhaConta.Location = new System.Drawing.Point(1160, 83);
            this.lblMinhaConta.Name = "lblMinhaConta";
            this.lblMinhaConta.Size = new System.Drawing.Size(100, 23);
            this.lblMinhaConta.TabIndex = 10;
            this.lblMinhaConta.TabStop = true;
            this.lblMinhaConta.Text = "Minha conta";
            this.lblMinhaConta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblMinhaConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMinhaConta_LinkClicked);
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSair.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSair.Location = new System.Drawing.Point(1160, 116);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(92, 18);
            this.lblSair.TabIndex = 11;
            this.lblSair.TabStop = true;
            this.lblSair.Text = "Sair";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnLimpaBusca);
            this.groupBox1.Controls.Add(this.cmbTipoBusca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomeCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.btnDeletarCliente);
            this.groupBox1.Controls.Add(this.dgvCliente);
            this.groupBox1.Controls.Add(this.btnCadCliente);
            this.groupBox1.Controls.Add(this.btnAlterarCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox1.Location = new System.Drawing.Point(244, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 381);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // btnLimpaBusca
            // 
            this.btnLimpaBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpaBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.btnLimpaBusca.ForeColor = System.Drawing.Color.White;
            this.btnLimpaBusca.Location = new System.Drawing.Point(603, 33);
            this.btnLimpaBusca.Name = "btnLimpaBusca";
            this.btnLimpaBusca.Size = new System.Drawing.Size(156, 46);
            this.btnLimpaBusca.TabIndex = 19;
            this.btnLimpaBusca.Text = "Limpar Busca";
            this.btnLimpaBusca.UseVisualStyleBackColor = false;
            this.btnLimpaBusca.Click += new System.EventHandler(this.btnLimpaBusca_Click);
            // 
            // cmbTipoBusca
            // 
            this.cmbTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusca.FormattingEnabled = true;
            this.cmbTipoBusca.Items.AddRange(new object[] {
            "Selecione",
            "Nome",
            "Email",
            "Usuario"});
            this.cmbTipoBusca.Location = new System.Drawing.Point(131, 40);
            this.cmbTipoBusca.Name = "cmbTipoBusca";
            this.cmbTipoBusca.Size = new System.Drawing.Size(155, 31);
            this.cmbTipoBusca.TabIndex = 18;
            this.cmbTipoBusca.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBusca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Buscar por:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(292, 45);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(78, 23);
            this.lblNomeCliente.TabIndex = 15;
            this.lblNomeCliente.Text = "Buscar:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(376, 42);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(221, 30);
            this.txtNomeCliente.TabIndex = 14;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnDeletarCliente.ForeColor = System.Drawing.Color.White;
            this.btnDeletarCliente.Location = new System.Drawing.Point(760, 185);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(126, 46);
            this.btnDeletarCliente.TabIndex = 13;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = false;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 81);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(748, 294);
            this.dgvCliente.TabIndex = 0;
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAlterarCliente.Location = new System.Drawing.Point(760, 133);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(126, 46);
            this.btnAlterarCliente.TabIndex = 13;
            this.btnAlterarCliente.Text = "Alterar";
            this.btnAlterarCliente.UseVisualStyleBackColor = false;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnGerarRelatorio);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox2.Location = new System.Drawing.Point(244, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 115);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relatórios";
            // 
            // bitchainDataSet
            // 
            this.bitchainDataSet.DataSetName = "BitchainDataSet";
            this.bitchainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitchainDataSetBindingSource
            // 
            this.bitchainDataSetBindingSource.DataSource = this.bitchainDataSet;
            this.bitchainDataSetBindingSource.Position = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblMinhaConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitchain - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bitchainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitchainDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.LinkLabel lblMinhaConta;
        private System.Windows.Forms.LinkLabel lblSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ComboBox cmbTipoBusca;
        private System.Windows.Forms.Label label4;
        private BitchainDataSet bitchainDataSet;
        private System.Windows.Forms.BindingSource bitchainDataSetBindingSource;
        private System.Windows.Forms.Button btnLimpaBusca;
    }
}