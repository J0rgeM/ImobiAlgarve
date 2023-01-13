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
    public partial class Editar : Form
    {
        DataTable dt;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public Editar()
        {
            InitializeComponent();
        }
        private void atualizar_datagridview()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * From addImovel", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Erro na Base de Dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpar()
        {
            txt_cod.Text = "";
            cbr_negocio.SelectedIndex = -1;
            cbr_tipo_imovel.SelectedIndex = -1;
            cbr_tipologia.SelectedIndex = -1;
            cbr_cidade.SelectedIndex = -1;
            cbr_preco.SelectedIndex = -1;
        }

        private void editar()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("UPDATE addImovel SET negocio=@negocio,tipo_imovel=@tipo_imovel,tipologia=@tipologia,cidade=@cidade,preco=@preco WHERE id =@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", int.Parse(txt_cod.Text));
                cmd.Parameters.AddWithValue("@negocio", cbr_negocio.Text);
                cmd.Parameters.AddWithValue("@tipo_imovel", cbr_tipo_imovel.Text);
                cmd.Parameters.AddWithValue("@tipologia", cbr_tipologia.Text);
                cmd.Parameters.AddWithValue("@cidade", cbr_cidade.Text);
                cmd.Parameters.AddWithValue("@preco", int.Parse(cbr_preco.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                atualizar_datagridview();
                limpar();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro a atualizar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackOffice_Load(object sender, EventArgs e)
        {  
            atualizar_datagridview();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from addImovel where id= " + dataGridView1.CurrentRow.Cells[0].Value, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                atualizar_datagridview();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro a remover registo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}