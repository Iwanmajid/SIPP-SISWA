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
using System.Data.SqlClient;

namespace WindowsFormsProject
{

    public partial class Form5Biodata : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "sipp_siswa";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        public Form5Biodata()
        {
            InitializeComponent();
        }

        private void panelFormBiodata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximized_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {

        }

        public String tbNamaLengkapPribadi, tbTempatLahirPribadi;
        private void textBoxNamaLengkap_TextChanged(object sender, EventArgs e)
        {
            tbNamaLengkapPribadi = ((TextBox)sender).Text;
        }

        private void textBoxTempatLahir_TextChanged(object sender, EventArgs e)
        {
            tbTempatLahirPribadi = ((TextBox)sender).Text;
        }

        private String JenisKelamin;
        private void radioButtonLakiLaki_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelamin = "Laki-Laki";
        }

        private void radioButtonPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelamin = "Perempuan";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd-mm-yyyy");
        }

        private void Form5Biodata_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            string username = textBoxUsername.Text;
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            string query = "SELECT * FROM datapribadi P where P.username = " + "'" + username + "'";
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            try
            {
                dbConn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //pribadi
                        textBoxUsername.Text = (reader["Username"].ToString());
                        textBoxNamaLengkap.Text = (reader["NamaLengkap"].ToString());

                        string jenisKelamin = (reader["JenisKelamin"].ToString());

                        if (jenisKelamin == "L")
                        {
                            radioButtonLakiLaki.Checked = true;
                        }
                        else if (jenisKelamin == "P")
                        {
                            radioButtonPerempuan.Checked = true;
                        }
                        textBoxTempatLahir.Text = (reader["TempatLahir"].ToString());
                        dateTimePicker1.Text = (reader["TanggalLahir"].ToString());
                        textBoxAlamat.Text = (reader["Alamat"].ToString());
                    }
                }
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Anda telah keluar dari akun");
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            string query = "SELECT Pelanggaran, PoinPelanggaran FROM riwayat_pelanggaran where username = " + "'" + username + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}