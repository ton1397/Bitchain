
namespace Bitchain
{
    partial class FormRelatorioClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RELATORIO_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BitchainDataSet = new Bitchain.BitchainDataSet();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RELATORIO_CLIENTESTableAdapter = new Bitchain.BitchainDataSetTableAdapters.RELATORIO_CLIENTESTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RELATORIO_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitchainDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RELATORIO_CLIENTESBindingSource
            // 
            this.RELATORIO_CLIENTESBindingSource.DataMember = "RELATORIO_CLIENTES";
            this.RELATORIO_CLIENTESBindingSource.DataSource = this.BitchainDataSet;
            // 
            // BitchainDataSet
            // 
            this.BitchainDataSet.DataSetName = "BitchainDataSet";
            this.BitchainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(12)))));
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Arial Black", 12F);
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(375, 112);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(180, 32);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIdCliente.Location = new System.Drawing.Point(11, 118);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 26);
            this.txtIdCliente.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "RelatorioClientes";
            reportDataSource1.Value = this.RELATORIO_CLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bitchain.RelatorioClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 150);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 349);
            this.reportViewer1.TabIndex = 2;
            // 
            // RELATORIO_CLIENTESTableAdapter
            // 
            this.RELATORIO_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatórios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 79);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id Cliente:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial Black", 12F);
            this.lblNomeCliente.Location = new System.Drawing.Point(371, 83);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(77, 23);
            this.lblNomeCliente.TabIndex = 5;
            this.lblNomeCliente.Text = "Cliente:";
            this.lblNomeCliente.Visible = false;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDataInicial.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(117, 118);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(123, 26);
            this.dtpDataInicial.TabIndex = 6;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDataFinal.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(246, 118);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(123, 26);
            this.dtpDataFinal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label3.Location = new System.Drawing.Point(242, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label4.Location = new System.Drawing.Point(113, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Inicial:";
            // 
            // FormRelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnGerarRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormRelatorioClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitchain - Relatórios";
            this.Load += new System.EventHandler(this.FormRelatorioClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RELATORIO_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitchainDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.TextBox txtIdCliente;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RELATORIO_CLIENTESBindingSource;
        private BitchainDataSet BitchainDataSet;
        private BitchainDataSetTableAdapters.RELATORIO_CLIENTESTableAdapter RELATORIO_CLIENTESTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}