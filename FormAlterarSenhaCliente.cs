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
    public partial class FormAlterarSenhaCliente : Form
    {
        public FormAlterarSenhaCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text == "")
            {
                MessageBox.Show("Campo Senha nova é obrigatório");
            }
            else if (txtConfirmarSenhaNova.Text == "")
            {
                MessageBox.Show("Campo confirmar senha nova é obrigatório");
            }
            else if (txtSenhaNova.Text != txtConfirmarSenhaNova.Text)
            {
                MessageBox.Show("Campo confirmar senha nova e Senha nova não coincidem");
            }
            else
            {
                string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
                SqlConnection connection = new SqlConnection(connetionString);
                SqlCommand command = new SqlCommand();
                try
                {

                    string senha_nova = ConverterSenhaEmHash(txtSenhaNova.Text);
                    string confirmar_senha_nova = ConverterSenhaEmHash(txtConfirmarSenhaNova.Text);
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE CLIENTES SET " +
                                            "SENHA=@SENHA " +
                                            "WHERE ID_CLIENTE=@ID_CLIENTE;";
                    command.Parameters.AddWithValue("@ID_CLIENTE", FormPrincipal.id_cliente);
                    command.Parameters.AddWithValue("@SENHA", senha_nova);
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
