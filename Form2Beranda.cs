using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsProject
{
    public partial class Form2Beranda : Form
    {
        public Form2Beranda()
        {
            InitializeComponent();            
        }        
             
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
                
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            Form3Masuk Masuk = new Form3Masuk();
            Masuk.Closed += (s, args) => this.Close();
            Masuk.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void buttonSyarat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4Peraturan Syarat = new Form4Peraturan();
            Syarat.Closed += (s, args) => this.Close();
            Syarat.ShowDialog();
            this.Close();
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

        private void Form1Beranda_Load(object sender, EventArgs e)
        {

        }
    }
}
