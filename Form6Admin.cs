using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsProject
{
    public partial class Form6Admin : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "sipp_siswa";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;
        public Form6Admin()
        {
            InitializeComponent();
        }
        private readonly Form1Container _form1;
        public Form6Admin(Form1Container form1)
        {
            _form1 = form1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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


        private Form2Beranda beranda = null;
        private Form3Masuk masuk = null;
        private Form4Peraturan syarat = null;
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Anda telah keluar dari akun");
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Visible = false;
            labelUsername.Visible = false;
            textBoxUsername.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            buttonSimpanPelanggaran.Visible = false;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            string query = "SELECT * FROM datapribadi";
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonCatat_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = true;
            labelUsername.Visible = true;
            textBoxUsername.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            buttonSimpanPelanggaran.Visible = true;
        }

        private void buttonSimpanPelanggaran_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Visible = false;
            labelUsername.Visible = false;
            textBoxUsername.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            buttonSimpanPelanggaran.Visible = false;
            string pelanggaran = "";
            int poin = 0;
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
            dbConn.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (textBoxUsername.Text == (reader["Username"].ToString()))
                    {
                        try
                        {
                            if (checkBox1.Checked == true)
                            {
                                pelanggaran += "\n" + checkBox1.Text;
                                poin += 4;
                            }
                            if (checkBox2.Checked == true)
                            {
                                pelanggaran += "\n" + checkBox2.Text;
                                poin += 5;
                            }
                            if (checkBox3.Checked == true)
                            {
                                pelanggaran += "\n" + checkBox3.Text;
                                poin += 4;
                            }
                            if (checkBox4.Checked == true)
                            {
                                pelanggaran += "\n" + checkBox4.Text;
                                poin += 5;
                            }
                            if (checkBox5.Checked == true)
                            {
                                pelanggaran += "\n" + checkBox5.Text;
                                poin += 5;
                            }
                            String query2 = string.Format("INSERT INTO riwayat_pelanggaran (Username, Pelanggaran, PoinPelanggaran) VALUES ('{0}','{1}', '{2}')",
                                textBoxUsername.Text, pelanggaran, poin);
                            dbConn = new MySqlConnection(connString);
                            MySqlCommand cmd1 = new MySqlCommand(query2, dbConn);
                            dbConn.Open();
                            cmd1.ExecuteNonQuery();
                            dbConn.Close();
                            if (poin <= 50)
                            {
                                String tingkatPelanggaran = "Wajar (Poin<=50)";
                                String Treatment = "Diperingatkan sesuai SOP";
                                String query3 = string.Format("INSERT INTO tingkat_pelanggaran (Username, TingkatPelanggaran, Treatment) VALUES ('{0}','{1}', '{2}')",
                                    textBoxUsername.Text, tingkatPelanggaran, Treatment);
                                MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);
                                dbConn.Open();
                                cmd3.ExecuteNonQuery();
                                dbConn.Close();
                            }
                            else if (poin > 50)
                            {
                                String tingkatPelanggaran = "Tidak Wajar (Poin>50)";
                                String Treatment = "Dibuatkan surat panggilan orang tua";
                                String query3 = string.Format("INSERT INTO tingkat_pelanggaran (Username, TingkatPelanggaran, Treatment) VALUES ('{0}','{1}', '{2}')",
                                    textBoxUsername.Text, tingkatPelanggaran, Treatment);
                                MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);
                                dbConn.Open();
                                cmd3.ExecuteNonQuery();
                                dbConn.Close();
                            }
                        }
                        catch
                        {
                            string query2 = "SELECT * FROM riwayat_pelanggaran where username = " + "'" + username + "'";
                            MySqlCommand cmd2 = new MySqlCommand(query2, dbConn);
                            try
                            {
                                using (MySqlDataReader reader2 = cmd2.ExecuteReader())
                                {
                                    while (reader2.Read())
                                    {
                                        poin = ((int)reader2["PoinPelanggaran"]);
                                        if (checkBox1.Checked == true)
                                        {
                                            pelanggaran += "\n" + checkBox1.Text;
                                            poin += 4;
                                        }
                                        if (checkBox2.Checked == true)
                                        {
                                            pelanggaran += "\n" + checkBox2.Text;
                                            poin += 5;
                                        }
                                        if (checkBox3.Checked == true)
                                        {
                                            pelanggaran += "\n" + checkBox3.Text;
                                            poin += 4;
                                        }
                                        if (checkBox4.Checked == true)
                                        {
                                            pelanggaran += "\n" + checkBox4.Text;
                                            poin += 5;
                                        }
                                        if (checkBox5.Checked == true)
                                        {
                                            pelanggaran += "\n" + checkBox5.Text;
                                            poin += 5;
                                        }
                                        String query4 = string.Format("update riwayat_pelanggaran set Pelanggaran = '{0}', PoinPelanggaran = '{1}' where username = '{2}'",
                                        pelanggaran, poin, username);
                                        dbConn = new MySqlConnection(connString);
                                        MySqlCommand cmd1 = new MySqlCommand(query4, dbConn);
                                        dbConn.Open();
                                        cmd1.ExecuteNonQuery();
                                        dbConn.Close();
                                        if (poin <= 50)
                                        {
                                            String tingkatPelanggaran = "Wajar (Poin<=50)";
                                            String Treatment = "Diperingatkan sesuai SOP";
                                            String query3 = string.Format("update tingkat_pelanggaran set TingkatPelanggaran = '{0}', Treatment = '{1}' where Username = '{2}'",
                                                tingkatPelanggaran, Treatment, username);
                                            MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);
                                            dbConn.Open();
                                            cmd3.ExecuteNonQuery();
                                            dbConn.Close();
                                        }
                                        else if (poin > 50)
                                        {
                                            String tingkatPelanggaran = "Tidak Wajar (Poin>50)";
                                            String Treatment = "Dibuatkan surat panggilan orang tua";
                                            String query3 = string.Format("update tingkat_pelanggaran set TingkatPelanggaran = '{0}', Treatment = '{1}' where Username = '{2}'",
                                                tingkatPelanggaran, Treatment, username);
                                            MySqlCommand cmd3 = new MySqlCommand(query3, dbConn);
                                            dbConn.Open();
                                            cmd3.ExecuteNonQuery();
                                            dbConn.Close();
                                        }
                                    }
                                }
                            }
                            finally
                            {
                                dbConn.Close();
                            }
                            MessageBox.Show("Pelanggaran berhasil direkam");
                            dataGridView1.Visible = true;
                            label1.Visible = false;
                            labelUsername.Visible = false;
                            textBoxUsername.Visible = false;
                            checkBox1.Visible = false;
                            checkBox2.Visible = false;
                            checkBox3.Visible = false;
                            checkBox4.Visible = false;
                            checkBox5.Visible = false;
                            buttonSimpanPelanggaran.Visible = false;
                            builder.Server = SERVER;
                            builder.Database = DATABASE;
                            builder.UserID = UID;
                            builder.Password = PASSWORD;
                            dbConn = new MySqlConnection(connString);
                            string queryUpdate = "SELECT * FROM riwayat_pelanggaran";
                            DataTable dt = new DataTable();
                            MySqlDataAdapter da;
                            da = new MySqlDataAdapter(queryUpdate, dbConn);
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }                    

                }

            }
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Visible = false;
            labelUsername.Visible = false;
            textBoxUsername.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            buttonSimpanPelanggaran.Visible = false;
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            string query = "SELECT * FROM riwayat_pelanggaran";
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonTingkatPelanggaran_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            string query = "SELECT * FROM tingkat_pelanggaran";
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter(query, dbConn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
