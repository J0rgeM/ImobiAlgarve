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
    public partial class Registar : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public Registar()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || txt_pass.Text == "" || txt_confpass.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Prencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txt_pass.Text != txt_confpass.Text)
            {
                MessageBox.Show("As palavras-passes não são iguais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //verificar se o username já está em uso 
                SqlConnection conn = new SqlConnection(cs);
                string qr = "SELECT username from entrar where username=@user";
                SqlCommand cmdd = new SqlCommand(qr, conn);
                cmdd.Parameters.AddWithValue("@user", txt_user .Text);
                conn.Open();
                var result = cmdd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    MessageBox.Show("O username já está em uso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //verificar se o email já está em uso 
                    SqlConnection connn = new SqlConnection(cs);
                    string qrr = "SELECT email from entrar where email=@mail";
                    SqlCommand cmddd = new SqlCommand(qrr, connn);
                    cmddd.Parameters.AddWithValue("@mail", txt_email.Text);
                    connn.Open();
                    var resultt = cmddd.ExecuteScalar();
                    connn.Close();

                    if (resultt != null)
                    {
                        MessageBox.Show("Este email já está em uso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            SqlConnection con = new SqlConnection(cs);
                            SqlCommand cmd = new SqlCommand("INSERT INTO entrar (username, nome, apelido, email, password, cargo) VALUES( @username, @nome, @apelido, @email, @password, @cargo)", con);
                            con.Open();
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@username", txt_user.Text);
                            cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                            cmd.Parameters.AddWithValue("@apelido", txt_apelido.Text);
                            cmd.Parameters.AddWithValue("@email", txt_email.Text);
                            cmd.Parameters.AddWithValue("@password", txt_pass.Text);
                            cmd.Parameters.AddWithValue("@cargo", cmb_Cargo.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                            this.Close();

                            txt_user.Text = "";
                            txt_nome.Text = "";
                            txt_apelido.Text = "";
                            txt_pass.Text = "";
                            txt_confpass.Text = "";
                            txt_email.Text = "";
                            cmb_Cargo.SelectedIndex = -1;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erro a registar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }

            }
            }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '\0')
            {
                txt_pass.PasswordChar = '*';
            }
            else
                txt_pass.PasswordChar = '\0';
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}

