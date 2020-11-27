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
    public partial class FormPerfil : Form
    {
        public static string id_usuario = FormPrincipal.id_usuario;
        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            getUserDatails();
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
                command.CommandText = "SELECT * FROM USUARIOS WHERE ID_USUARIO=@ID_USUARIO;";
                command.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    command.CommandText = "UPDATE USUARIOS SET " +
                                            "NOME=@NOME, " +
                                            "EMAIL=@EMAIL, " +
                                            "DT_NASCIMENTO=@DT_NASCIMENTO, " +
                                            "USUARIO=@USUARIO " +
                                            "WHERE ID_USUARIO=@ID_USUARIO;";
                    command.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
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
                    getUserDatails();
                }
            }
        }

        private void lblAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAlterarSenha formAlterarSenha = new FormAlterarSenha();
            formAlterarSenha.Show();
        }
    }
}
