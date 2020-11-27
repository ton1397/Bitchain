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
    public partial class FormAlterarCliente : Form
    {
        public FormAlterarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Campo email é obrigatório");
            }
            else if (dtpNascimento.Text == "")
            {
                MessageBox.Show("Campo data de nascimento é obrigatório");
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo usuario é obrigatório");
            }
            else
            {
                string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand command = new SqlCommand();
                try
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string dt_nascimento = dtpNascimento.Text;
                    string usuario = txtUsuario.Text;
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE CLIENTES SET " +
                                            "NOME=@NOME, " +
                                            "EMAIL=@EMAIL, " +
                                            "DT_NASCIMENTO=@DT_NASCIMENTO, " +
                                            "USUARIO=@USUARIO " +
                                            "WHERE ID_CLIENTE=@ID_CLIENTE;";
                    command.Parameters.AddWithValue("@ID_CLIENTE", FormPrincipal.id_cliente);
                    command.Parameters.AddWithValue("@NOME", nome);
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@DT_NASCIMENTO", dt_nascimento);
                    command.Parameters.AddWithValue("@USUARIO", usuario);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dados alterados com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }
        }

        private void FormAlterarCliente_Load(object sender, EventArgs e)
        {
            getUserDatails();
            txtNome.Focus();
        }

        private void getUserDatails()
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM CLIENTES WHERE ID_CLIENTE=@ID_CLIENTE;";
                command.Parameters.AddWithValue("@ID_CLIENTE", FormPrincipal.id_cliente);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine(reader);
                if (reader.Read())
                {

                    txtNome.Text = reader["NOME"].ToString();
                    txtEmail.Text = reader["EMAIL"].ToString();
                    dtpNascimento.Text = reader["DT_NASCIMENTO"].ToString();
                    txtUsuario.Text = reader["USUARIO"].ToString();
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

        private void lblAlterarSenhaCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAlterarSenhaCliente formAlterarSenhaCliente = new FormAlterarSenhaCliente();
            formAlterarSenhaCliente.Show();
        }
    }
}
