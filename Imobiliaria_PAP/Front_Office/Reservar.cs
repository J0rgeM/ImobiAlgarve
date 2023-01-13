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

namespace Imobiliaria_PAP
{
    public partial class Reservar : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        DataTable dt;
        public Reservar()
        {
            InitializeComponent();
            FillCombo();

        }

        void FillCombo(){
            string Query = "SELECT * FROM addImovel";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader read;

            try
            {
                con.Open();
                read = cmd.ExecuteReader();

                while(read.Read())
                {
                     string id = read["id"].ToString();
                    cb_id.Items.Add(id);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_id_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM addImovel WHERE id='" + cb_id.Text + "'";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader read;

            try
            {
                con.Open();
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    string negocio = read["negocio"].ToString();
                    string tipo_imovel = read["tipo_imovel"].ToString();
                    string tipologia = read["tipologia"].ToString();
                    string cidade = read["cidade"].ToString();
                    string preco = read["preco"].ToString();
                    string reservado = read["reservado"].ToString();
                    txt_negocio.Text = negocio;
                    txt_tipoimovel.Text = tipo_imovel;
                    txt_tipologia.Text = tipologia;
                    txt_cidade.Text = cidade;
                    txt_preco.Text = preco;
                    metroTextBox1.Text = reservado;

                }
                if (metroTextBox1 == null)
                {
                    metroTextBox1.Text = "Sem reserva";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (cb_id.SelectedIndex == -1)
            {
                MessageBox.Show("Existem campos por preencher", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (metroTextBox1.Text != "Reservado")
                {
                    // dt.Columns["reservado"] = "Reservado";
                    metroTextBox1.Text = "Reservado";
                }

                string message = "Carregue no botão OK para confirmar a sua reserva!";
                string title = "Confirmar Reserva";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("UPDATE addImovel SET agendamento=@agendamento, reservado=@reservado WHERE id =@id", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", int.Parse(cb_id.Text));
                    cmd.Parameters.AddWithValue("@agendamento", metroDateTime1.Value);
                    cmd.Parameters.AddWithValue("@reservado", metroTextBox1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    metroDateTime1.Value = DateTime.Now;
                    metroTextBox1.Text = "Sem reserva";
                }
                else
                {
                    // Do something  
                }
            }
        }

    }
}
