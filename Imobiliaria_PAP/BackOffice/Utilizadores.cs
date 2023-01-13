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
    public partial class Utilizadores : Form
    {
        DataTable dt;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";

        public Utilizadores()
        {
            InitializeComponent();
        }

        private void atualizar_datagridview()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * From entrar", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Erro na Base de Dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editar()
        {
            if (txt_password.Text != txt_confpassword.Text)
            {
                txt_password.Text = "";
                txt_confpassword.Text = "";
                txt_password.Focus();
                txt_confpassword.Focus();
                MessageBox.Show("As palavras-passes não são iguais!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                try
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("UPDATE entrar SET username=@username,nome=@nome,apelido=@apelido,email=@email, password=@password, cargo=@cargo WHERE id =@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_codigo.Text));
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                    cmd.Parameters.AddWithValue("@apelido", txt_apelido.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@cargo", cmb_Cargo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    atualizar_datagridview();

                    txt_codigo.Text = "";
                    txt_username.Text = "";
                    txt_nome.Text = "";
                    txt_apelido.Text = "";
                    txt_email.Text = "";
                    txt_password.Text = "";
                    txt_confpassword.Text = "";
                    cmb_Cargo.SelectedIndex = -1;

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro a ataulizar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        private void Utilizadores_Load(object sender, EventArgs e)
        {
            atualizar_datagridview();
        }      
        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
           if(metroTextBox2.Text=="")
            {
                atualizar_datagridview();
            }else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM entrar WHERE username= '" + metroTextBox2.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 1)
                return;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from entrar where id= " + dataGridView1.CurrentRow.Cells[0].Value, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                atualizar_datagridview();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro a remover utilizador!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_username.Text = "";
            txt_nome.Text = "";
            txt_apelido.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            txt_confpassword.Text = "";
            cmb_Cargo.SelectedIndex = -1;
        }

    }
    
}

