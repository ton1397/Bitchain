using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitchain
{
    public partial class FormRelatorioClientes : Form
    {
        public FormRelatorioClientes()
        {
            InitializeComponent();
        }

        private void FormRelatorioClientes_Load(object sender, EventArgs e)
        {
            dtpDataInicial.Value = DateTime.Now.AddDays(1 - DateTime.Now.Day).AddMonths(-1);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            if(txtIdCliente.Text == "")
            {
                MessageBox.Show("Por favor, insira o código do cliente");
            }
            else
            {
                // TODO: esta linha de código carrega dados na tabela 'BitchainDataSet.RELATORIO_CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
                this.RELATORIO_CLIENTESTableAdapter.Fill(this.BitchainDataSet.RELATORIO_CLIENTES, int.Parse(txtIdCliente.Text), dtpDataInicial.Value.ToString(), dtpDataFinal.Value.ToString());
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
