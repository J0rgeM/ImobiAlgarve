using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Imobiliaria_PAP
{
    public partial class NovaPassword : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        private string username = AlterarPassword.to;
        public NovaPassword()
        {
            InitializeComponent();
        }

        public static string id;
        private void metroButton1_Click(object sender, EventArgs e)
        { 
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                SqlCommand cmdd = new SqlCommand("SELECT id FROM entrar WHERE email='"+ txt_email.Text.Trim()+"'", conn);
                var result = cmdd.ExecuteScalar();
                conn.Close();
                id = result.ToString();

             try
            {
                if (txt_pass.Text == txtNovaPassVer.Text)
               {
                  SqlConnection con = new SqlConnection(cs);
                  con.Open();
                  SqlCommand cmd = new SqlCommand("UPDATE entrar SET password=@password WHERE id=@id ", con);
                   cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                   con.Close();
                    MessageBox.Show("Mudou a password com sucesso!");
               }
                 else
                {
                    MessageBox.Show("As passwords não são iguais!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro a alterar a palavra-passe!");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0' && txtNovaPassVer.PasswordChar == '\0')
            {
                txt_pass.PasswordChar = '*';
                txtNovaPassVer.PasswordChar = '*';
            }
            else
            {
                txt_pass.PasswordChar = '\0';
                txtNovaPassVer.PasswordChar = '\0';
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
