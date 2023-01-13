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
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Imobiliaria_PAP
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
            carregarImagem();
        }

        int number = 0;
        private void carregarImagem()
        {
            Random r1 = new Random();
            number = r1.Next(100, 1000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureBox1.Image = image;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            carregarImagem();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == number.ToString())
            {
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Código inválido! Tente de novo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}

