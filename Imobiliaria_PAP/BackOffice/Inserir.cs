using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Imobiliaria_PAP
{
    public partial class Inserir : Form
    {
        DataTable dt;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";
        public Inserir()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            cb_negocio.SelectedIndex = -1;
            cb_tipo_imovel.SelectedIndex = -1;
            cb_tipologia.SelectedIndex = -1;
            cb_cidade.SelectedIndex = -1;
            cb_preco.SelectedIndex = -1;
        }

        private void add()
        {
            if (cb_negocio.SelectedIndex == -1 ||
                          cb_tipo_imovel.SelectedIndex == -1 ||
                          cb_tipologia.SelectedIndex == -1 ||
                          cb_cidade.SelectedIndex == -1 ||
                          cb_preco.SelectedIndex == -1)
            {
                MessageBox.Show("Existem campos por preencher!", "Campos Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("INSERT INTO addImovel (negocio,tipo_imovel,tipologia,cidade,preco) values (@negocio,@tipo_imovel,@tipologia,@cidade,@preco)", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@negocio", cb_negocio.Text);
                    cmd.Parameters.AddWithValue("@tipo_imovel", cb_tipo_imovel.Text);
                    cmd.Parameters.AddWithValue("@tipologia", cb_tipologia.Text);
                    cmd.Parameters.AddWithValue("@cidade", cb_cidade.Text);
                    cmd.Parameters.AddWithValue("@preco", cb_preco.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    limpar();


                }
                catch (Exception)
                {
                    MessageBox.Show("Erro a inserir os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
