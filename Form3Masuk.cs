using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsProject
{
    public partial class Form3Masuk : Form
    {
        private const String SERVER = "127.0.0.1";
        private const String DATABASE = "sipp_siswa";
        private const String UID = "root";
        private const String PASSWORD = "";
        private static MySqlConnection dbConn;

        public Form3Masuk()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void Form3Masuk_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panellogin.Visible = true;            
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
        
        private void buttonMasuk_Click_1(object sender, EventArgs e)
        {
            Form5Biodata biodata = new Form5Biodata();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.Database = DATABASE;
            builder.UserID = UID;
            builder.Password = PASSWORD;            
            String query = string.Format("SELECT * FROM pendaftaran, admin");
            String connString = builder.ToString();
            dbConn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(query, dbConn);
            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (textBoxNmPnggnMasuk.Text == "admin" && textBoxSandiMasuk.Text == "admin123")
            {
                Form6Admin admin = new Form6Admin();
                MessageBox.Show("Login berhasil");
                panellogin.Visible = false;
                admin.TopLevel = false;
                admin.Size = panelContMasuk.Size;
                panelContMasuk.Controls.Add(admin);
                admin.Show();              
                return;
            }
            else
            {
                while (reader.Read())
                {
                    if (textBoxNmPnggnMasuk.Text.Equals(reader["Username"]) && textBoxSandiMasuk.Text.Equals(reader["Sandi"]))
                    {                        
                        biodata = new Form5Biodata();
                        MessageBox.Show("Login berhasil");                        
                        panellogin.Visible = false;
                        biodata.TopLevel = false;
                        biodata.Size = panelContMasuk.Size;
                        panelContMasuk.Controls.Add(biodata);
                        biodata.textBoxUsername.Text = textBoxNmPnggnMasuk.Text;
                        biodata.Show();
                        return;
                    }
                }
            }
            MessageBox.Show("Nama pengguna atau sandi tidak sesuai");
            dbConn.Close();
        }
    }
}
