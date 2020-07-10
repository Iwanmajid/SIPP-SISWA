using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Form1Container : Form
    {
        public Form1Container()
        {
            InitializeComponent();
        }

        private Form2Beranda beranda = null;
        private Form3Masuk   masuk   = null;
        private Form4Peraturan  syarat  = null;

        private void buttonCBeranda_Click(object sender, EventArgs e)
        {
            if (masuk != null & syarat != null)
            {
                panelContainer.Controls.Remove(masuk);
                panelContainer.Controls.Remove(syarat);
                masuk.Close(); syarat.Close();
                masuk = null; syarat = null;
            }

            Form2Beranda Formberanda = new Form2Beranda();
            Formberanda.TopLevel = false;
            Formberanda.Size = panelContainer.Size;
            panelContainer.Controls.Add(Formberanda);
            Formberanda.Show();
        }

        private void buttonCMasuk_Click(object sender, EventArgs e)
        {
            buttonCMasuk.Enabled = false;
            buttoncKeluar.Enabled = true;
            buttoncKeluar.Visible = true;
            if (beranda != null & syarat != null)
            {
                panelContainer.Controls.Remove(beranda);
                panelContainer.Controls.Remove(syarat);
                beranda.Close(); syarat.Close();
                beranda = null; syarat = null;
            }
            Form3Masuk Formmasuk = new Form3Masuk();
            Formmasuk.TopLevel = false;
            Formmasuk.Size = panelContainer.Size;
            panelContainer.Controls.Add(Formmasuk);
            Formmasuk.Show();
        }

        private void buttonCSyarat_Click(object sender, EventArgs e)
        {
            if (beranda != null & masuk != null)
            {
                panelContainer.Controls.Remove(beranda);
                panelContainer.Controls.Remove(masuk);
                beranda.Close(); masuk.Close();
                beranda = null; masuk = null;
            }
            Form4Peraturan Formsyarat = new Form4Peraturan();
            Formsyarat.TopLevel = false;
            Formsyarat.Size = panelContainer.Size;
            panelContainer.Controls.Add(Formsyarat);
            Formsyarat.Show();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelAtas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form0Container_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (beranda != null & masuk != null)
            {
                panelContainer.Controls.Remove(beranda);
                panelContainer.Controls.Remove(masuk);
                beranda.Close(); masuk.Close();
                beranda = null; masuk = null;
            }
            Form1Container container = new Form1Container();
            container.TopLevel = false;
            container.Size = panelContainer.Size;
            panelContainer.Controls.Add(container);
            container.Show();
        }

        private void buttoncKeluar_Click(object sender, EventArgs e)
        {
            buttonCMasuk.Enabled = true;
            buttoncKeluar.Enabled = false;
            buttoncKeluar.Visible = false;
            if (masuk != null & syarat != null)
            {
                panelContainer.Controls.Remove(masuk);
                panelContainer.Controls.Remove(syarat);
                masuk.Close(); syarat.Close();
                masuk = null; syarat = null;
            }
            Form2Beranda Formberanda = new Form2Beranda();
            Formberanda.TopLevel = false;
            Formberanda.Size = panelContainer.Size;
            panelContainer.Controls.Add(Formberanda);
            Formberanda.Show();
        }
    }
}
