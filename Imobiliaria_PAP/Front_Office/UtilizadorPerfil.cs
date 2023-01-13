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
using System.Security.Permissions;

namespace Imobiliaria_PAP
{
    public partial class UtilizadorPerfil : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public UtilizadorPerfil()
        {
            InitializeComponent();
            initializeEditControls();
            preencher();
        }

        private void initializeEditControls()
        {
            Panel1.Visible = false;
        }
        
        public void preencher()
        {
                SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT * FROM entrar ", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            //cmd.addwithvalue("@id", ...);
            //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblID.Text));
            cmd.ExecuteNonQuery();
            SqlDataReader da;
            da = cmd.ExecuteReader();

            if(da.HasRows == true)
            {

            try
           {
                while (da.Read())
                {
                    lblID.Text = da.GetValue(0).ToString();
                    lblUser.Text = da.GetValue(1).ToString();
                    lblName.Text = da.GetValue(2).ToString();
                    lblLastName.Text = da.GetValue(3).ToString();
                    lblMail.Text = da.GetValue(5).ToString();

                    textBox1.Text = da.GetValue(0).ToString();
                    txtUsername.Text = da.GetValue(1).ToString();
                    txtFirstName.Text = da.GetValue(2).ToString();
                    txtLastName.Text = da.GetValue(3).ToString();
                    txtEmail.Text = da.GetValue(5).ToString();
                }
              //  con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void reset()
        {
            initializeEditControls();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Panel1.Width += 20;
            if (Panel1.Width >= 400)
            {
                Timer1.Stop();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE entrar SET username=@username, nome=@nome, apelido=@apelido, email=@email WHERE id =@id", con);
                // SqlCommand cmd = new SqlCommand("UPDATE entrar SET username=@username, nome=@nome, apelido=@apelido, password=@password, email=@email, cargo=@cargo WHERE id =@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@nome", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@apelido", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                               
                txtUsername.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                preencher();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkEditarPerfil_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Width = 10;
            Panel1.Visible = true;
            Timer1.Start();
        }

        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
