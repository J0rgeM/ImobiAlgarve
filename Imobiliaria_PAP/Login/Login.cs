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
using System.Runtime.InteropServices;
using Imobiliaria_PAP.Imob_dbDataSetTableAdapters;

namespace Imobiliaria_PAP
{
    public partial class Login : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
        }
        #region Form Metodos
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Silver;
            }
        }
        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Palavra-passe")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.WhiteSmoke;
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Palavra-passe";
                txt_pass.ForeColor = Color.Silver;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            timer1.Start();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        #endregion
        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registar registar = new Registar();
            registar.ShowDialog();
            //this.Close();
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AlterarPassword alterar = new AlterarPassword();
            alterar.ShowDialog();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
                string email;
                string password;
                string cargo;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd =  new SqlCommand("SELECT * From entrar  where email='" + txt_email.Text + "' and password='" + txt_pass.Text + "'", con);
              //  SqlCommand cmd = new SqlCommand("SELECT * From entrar  where email=@email and password=@password cargo=@cargo", con);
            //cmd.Parameters.AddWithValue("@email", txt_email);
            //cmd.Parameters.AddWithValue("@password", txt_pass);
            //cmd.Parameters.AddWithValue("@cargo", cargo);
            //cmd.Connection = con;
           // cargo.ExecuteScalar();
            //SqlDataAdapter adapt = new SqlDataAdapter("SELECT * From entrar  where email='" + txt_email.Text +"' and password='" + txt_pass.Text + "'", con);
              DataTable dt = new DataTable();
                // adapt.Fill(dt);
               SqlDataReader dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {  
                    email = dtr["email"].ToString();
                    password = dtr["password"].ToString();
                    cargo = dtr["cargo"].ToString();


                if (txt_email.Text == "")
                        {
                            msgError("Incorrect username or password entered. \n   Please try again.");
                            //MetroFramework.MetroMessageBox.Show(this, "Email inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_email.Text = "";
                            txt_email.Focus();
                            return;
                        }
                        if (txt_pass.Text == "")
                        {
                              msgError("Incorrect username or password entered. \n   Please try again.");
                             //MetroFramework.MetroMessageBox.Show(this, "Password inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                              txt_pass.Text = "";
                              txt_pass.UseSystemPasswordChar = false;
                              txt_pass.Focus();
                              return;
                        }
          try {
                    if (email != txt_email.Text && password != txt_pass.Text)
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                    }
                        if (email == txt_email.Text && password == txt_pass.Text && cargo== "Administrador")
                      {
                  this.Hide();
                  BackOffice menu = new BackOffice();
                  BemVindo bemvindo = new BemVindo();
                  bemvindo.lbl_username.Text = txt_email.Text;
                  bemvindo.ShowDialog();
                  menu.Show();
                      }
                  else
                  {
                      this.Hide();
                      Front_Office menuprincipal = new Front_Office();
                      BemVindo bemvindo = new BemVindo();
                      bemvindo.lbl_username.Text = txt_email.Text;
                      bemvindo.ShowDialog();
                      menuprincipal.Show();

                   }
                }

                catch (Exception)
                     {
                            con.Close();
                            msgError("Incorrect username or password entered. \n   Please try again.");
                            // MessageBox.Show("Login inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_email.Text = "Email";
                            txt_pass.Text = "Palavra-passe";
                            txt_pass.UseSystemPasswordChar = false;
                           // Captcha dashboard = new Captcha();
                            //dashboard.ShowDialog();

                        }
                      }
        }
    }


    /*if (dt.Rows.Count == 1)
     {
         this.Hide();
         Front_Office menuprincipal = new Front_Office();
         BemVindo bemvindo = new BemVindo();
         bemvindo.ShowDialog();
         menuprincipal.Show();
         menuprincipal.lblUserName.Text = txt_email.Text;
         BackOffice office = new BackOffice();
         office.lblUserName.Text = txt_email.Text;

         this.Close();
     }
     else
     {
         MetroFramework.MetroMessageBox.Show(this, "Login inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

     }*/
}



/*   private void button1_Click(object sender, EventArgs e)
   {
       SqlConnection con = new SqlConnection(cs);
       SqlCommand cmd = new SqlCommand("SELECT * from entrarr where email='" +txt_email.Text + "'and password='"+txt_pass.Text+"'",con);
       SqlDataReader reader;

       con.Open();
       reader = cmd.ExecuteReader();
       int count = 0;
       string userRole = string.Empty;
        while(reader.Read())
        {
            count = 1;
           userRole = reader["cargo"].ToString();
       }
       if (count==1)
       {
           this.Hide();
           BackOffice menu = new BackOffice();
           BemVindo bemvindo = new BemVindo();
           bemvindo.ShowDialog();
           menu.Show();
       }
       else 
       {
           this.Hide();
           Front_Office menuprincipal = new Front_Office();
           BemVindo bemvindo = new BemVindo();
           bemvindo.ShowDialog();
           menuprincipal.Show();
       }

   }
}



}



*/
