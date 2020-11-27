using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitchain
{
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
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
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo senha é obrigatório");
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
                    string senha = txtSenha.Text;
                    senha = ConverterSenhaEmHash(senha);
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO CLIENTES(NOME,EMAIL,DT_NASCIMENTO,USUARIO,SENHA)VALUES(@NOME,@EMAIL,@DT_NASCIMENTO,@USUARIO,@SENHA);";
                    command.Parameters.AddWithValue("@NOME", nome);
                    command.Parameters.AddWithValue("@EMAIL", email);
                    command.Parameters.AddWithValue("@DT_NASCIMENTO", dt_nascimento);
                    command.Parameters.AddWithValue("@USUARIO", usuario);
                    command.Parameters.AddWithValue("@SENHA", senha);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    dtpNascimento.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    this.Close();
                }
            }
        }

        private string ConverterSenhaEmHash(string Senha)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Senha));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
