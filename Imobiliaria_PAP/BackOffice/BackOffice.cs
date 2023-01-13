using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Imobiliaria_PAP
{
    public partial class BackOffice : Form
    {
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jorge\OneDrive\Ambiente de Trabalho\Imobiliaria_PAP\Imobiliaria_PAP\Imob_db.mdf;Integrated Security=True;Connect Timeout=30";

        public BackOffice()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
           // preencher();
        }
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panel_principal.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;
        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btn_maximizar.Visible = false;
            btn_normal.Visible = true;
        }
        private void btn_normal_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btn_normal.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Width == 230)
            {
                this.tm_diminuirmenu.Start();
                panel1.Visible = false;
                panel2.Visible = false;
            }
            else if (panel_menu.Width == 55)
            {
                this.tm_expandirmenu.Start();
                panel1.Visible = true;
                panel2.Visible = true;
            }

            //-------SEM EFEITO 
            /*  if (panel_menu.Width == 55)
              {
                  panel_menu.Width = 230;
              }
              else
                  panel_menu.Width = 55; */
        }

        private void tm_expandirmenu_Tick(object sender, EventArgs e)
        {
            if (panel_menu.Width >= 230)
                this.tm_expandirmenu.Stop();
            else
                panel_menu.Width = panel_menu.Width + 5;
        }

        private void tm_diminuirmenu_Tick(object sender, EventArgs e)
        {
            if (panel_menu.Width <= 55)
                this.tm_diminuirmenu.Stop();
            else
                panel_menu.Width = panel_menu.Width - 5;
        }

        private void tm_data_hora_Tick(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void panel_barratitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void preencher()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT * FROM entrar ", con);
            con.Open();
            SqlDataReader da;
            da = cmd.ExecuteReader();
            try
            {
                while (da.Read())
                {
                    lblUser.Text = da.GetValue(1).ToString();
                    lblEmail.Text = da.GetValue(5).ToString();
                    lblCargo.Text = da.GetValue(6).ToString();

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
            MostrarFormLogo(); 
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel_forms.Controls.OfType<MiForm>().FirstOrDefault();//Procura formularios
                                                                                //se existe ou nao existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel_forms.Controls.Add(formulario);
                panel_forms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //se existe ou nao existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void AbrirFormPanel(object formFilho)
        {
            if (this.panel_forms.Controls.Count > 0)
                this.panel_forms.Controls.RemoveAt(0);
            Form fh = formFilho as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_forms.Controls.Add(fh);
            this.panel_forms.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisar frm = new Pesquisar();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoFecharForms);
            AbrirFormPanel(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Editar frm = new Editar();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoFecharForms);
            AbrirFormPanel(frm);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Inserir frm = new Inserir();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoFecharForms);
            AbrirFormPanel(frm);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Utilizadores frm = new Utilizadores();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoFecharForms);
            AbrirFormPanel(frm);
        }

        private void MostrarFormLogo()
        {
            AbrirFormPanel(new FormLogo());
        }
        private void MostrarFormLogoFecharForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
    }
}
