using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitchain
{
    public partial class FormPrincipal : Form
    {
        public static string id_usuario = FormLogin.id_usuario;
        public static string id_cliente = "";
        //public static string id_usuario = "1";
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //FAZER UM SELECT NA BASE DE DADOS PARA TRAZER AS INFORMAÇÕES DO USUARIO NA TELA PRINCIPAL
            getUserName();
            getAllClients();
            dgvCliente.ClearSelection();
            cmbTipoBusca.SelectedIndex = 0;
        }

        private void getUserName()
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT NOME FROM USUARIOS WHERE ID_USUARIO=@ID_USUARIO;";
                command.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string nome = reader["NOME"].ToString();
                    string[] arr_nome = nome.Split(' ');
                    lblNome.Text = arr_nome[0].ToString();

                }
                else
                {
                    MessageBox.Show("nenhum usuario foi encontrado com este id");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void getAllClients()
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            string query = "SELECT ID_CLIENTE AS ID, " +
                            "NOME AS Nome, " +
                            "EMAIL AS Email, " +
                            "DT_NASCIMENTO AS Nascimento, " +
                            "USUARIO AS Usuario " +
                            "FROM CLIENTES;";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connetionString);


                DataSet ds = new DataSet();
                da.Fill(ds, "Clientes");
                dgvCliente.AutoGenerateColumns = true;
                dgvCliente.DataSource = ds.Tables["Clientes"].DefaultView;
                dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja Sair do Sistema?", "", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void lblMinhaConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPerfil formPerfil = new FormPerfil();
            formPerfil.Show();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente formCadCliente = new FormCadCliente();
            formCadCliente.ShowDialog();
            dgvCliente.DataSource = null;
            getAllClients();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedCells.Count == 1)
            {
                FormAlterarCliente formAlterarCliente = new FormAlterarCliente();
                int row = Convert.ToInt32(dgvCliente.CurrentCell.RowIndex);
                string id = dgvCliente.Rows[row].Cells[0].Value.ToString();
                id_cliente = id;
                formAlterarCliente.ShowDialog();
                dgvCliente.DataSource = null;
                getAllClients();
            }
            else if(dgvCliente.SelectedCells.Count > 1)
            {
                MessageBox.Show("Selecione somente um registro para alterar");
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar");
            }
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            
            if (dgvCliente.SelectedRows.Count >= 1)
            {
                DialogResult result = MessageBox.Show("Deseja realmente deletar esses registros?", "", MessageBoxButtons.YesNo);
                if (result.ToString() == "Yes")
                {
                    try
                    {
                        
                        foreach (DataGridViewRow row in dgvCliente.SelectedRows)
                        {
                            string id = dgvCliente.Rows[row.Index].Cells[0].Value.ToString();
                            DeletarCliente(id);
                        }
                        MessageBox.Show("Dados deletados com sucesso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dgvCliente.DataSource = null;
                        getAllClients();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos uma linha da tabela para deletar. Caso deseje deletar mais de uma linha, pressione o CTRL e selecione as linhas que deseja deletar.");
            }
        }

        private void DeletarCliente(string id)
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM CLIENTES " +
                                    "WHERE ID_CLIENTE=@ID_CLIENTE;";
            command.Parameters.AddWithValue("@ID_CLIENTE", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorioClientes relatorio_Clientes = new FormRelatorioClientes();
            relatorio_Clientes.Show();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            int index = cmbTipoBusca.SelectedIndex;

            switch (index)
            {
                case 1:
                    getSearchClients("NOME");
                    break;
                case 2:
                    getSearchClients("EMAIL");
                    break;
                case 3:
                    getSearchClients("USUARIO");
                    break;
                default:
                    MessageBox.Show("Não foi possivel determinar o indice campo selecionar");
                    break;
            }
        }

        private void cmbTipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            if (cmbTipoBusca.SelectedIndex == 0)
            {
                lblNomeCliente.Enabled = false;
                txtNomeCliente.Enabled = false;
            }
            else
            {
                lblNomeCliente.Enabled = true;
                txtNomeCliente.Enabled = true;
            }
        }

        private void btnLimpaBusca_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            cmbTipoBusca.SelectedIndex = 0;
            dgvCliente.DataSource = null;
            getAllClients();
        }

        public void getSearchClients(string tipo)
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            string query = "SELECT ID_CLIENTE AS ID, " +
                           "NOME AS Nome, " +
                           "EMAIL AS Email, " +
                           "DT_NASCIMENTO AS Nascimento, " +
                           "USUARIO AS Usuario " +
                           "FROM CLIENTES " +
                           "WHERE " + tipo + " LIKE '%" + txtNomeCliente.Text + "%';";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connetionString);


                DataSet ds = new DataSet();
                da.Fill(ds, "Clientes");
                dgvCliente.AutoGenerateColumns = true;
                dgvCliente.DataSource = ds.Tables["Clientes"].DefaultView;
                dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
