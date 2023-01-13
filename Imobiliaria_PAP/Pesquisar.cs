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
    public partial class Pesquisar : Form
    {
        DataTable dt;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public Pesquisar()
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
                dataGridView2.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            atualizar_datagridview();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_preco.Text == "")
            {
                cmb_preco.Text = "1000000";
            }
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM addImovel WHERE negocio like '%" + cmb_negocio.Text + "%' AND tipo_imovel like '%" + cmb_tipoimovel.Text + "%' AND tipologia like '%" + cmb_tipologia.Text + "%' AND cidade like '%" + cmb_cidade.Text + "%' AND preco <= '" + cmb_preco.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "addImovel");
            dataGridView2.DataSource = ds.Tables["addImovel"].DefaultView;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cmb_negocio.SelectedIndex = -1;
            cmb_tipoimovel.SelectedIndex = -1;
            cmb_tipologia.SelectedIndex = -1;
            cmb_cidade.SelectedIndex = -1;
            cmb_preco.SelectedIndex = -1;
            dataGridView2.Columns.Clear();
            atualizar_datagridview();
        }
    }
}

