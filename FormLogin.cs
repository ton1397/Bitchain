using Microsoft.SqlServer.Server;
using Org.BouncyCastle.Crypto.Tls;
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
    public partial class FormLogin : Form
    {
        public static string id_usuario = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadUsuario formCadUsuario = new FormCadUsuario();
            formCadUsuario.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string connetionString = "Data Source=DESKTOP-NJTO7KN;Initial Catalog=bitchain;user ID=DESKTOP-NJTO7KN/welli;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand();
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;
                senha = ConverterSenhaEmHash(senha);
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT ID_USUARIO FROM USUARIOS WHERE USUARIO=@USUARIO AND SENHA=@SENHA;";
                command.Parameters.AddWithValue("@USUARIO", usuario);
                command.Parameters.AddWithValue("@SENHA", senha);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id_usuario = reader["ID_USUARIO"].ToString();
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("usuario e/ou senha invalidos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
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

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

    }
}
