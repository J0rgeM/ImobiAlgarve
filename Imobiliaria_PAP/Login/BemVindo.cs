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
    public partial class BemVindo : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public BemVindo()
        {
            InitializeComponent();
            // preencher();
          //  lbl_username.Text = Login

        }

        public void preencher()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT name FROM entrar WHERE id=@id ", con);
            con.Open();
            SqlDataReader da;
            da = cmd.ExecuteReader();
           // string id;
         //   cmd.Parameters.AddWithValue("@id", int.Parse(lbl_invisible.Text));
            try
            {
                while (da.Read()) 
                {
                  //  lbl_invisible.Text = da.GetValue(0).ToString();
                    lbl_username.Text = da.GetValue(1).ToString();

                }
                //  con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            timer1.Start();

            /*
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM entrar"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        lbl_username.Text = sdr["nome"].ToString();

                    }
                    con.Close();
                }
            }*/


         /*   SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "SELECT username FROM entrar WHERE username='" + lbl_username.Text + "'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lbl_username.Text = dt.Rows[1]["username"].ToString();
            }
            con.Close();*/
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString();
            if (circularProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

    }
}
