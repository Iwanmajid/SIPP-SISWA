namespace WindowsFormsProject
{
    partial class Form5Biodata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDataPribadi = new System.Windows.Forms.Panel();
            this.buttonRiwayat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTempatLahir = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTempatLahir = new System.Windows.Forms.Label();
            this.radioButtonPerempuan = new System.Windows.Forms.RadioButton();
            this.radioButtonLakiLaki = new System.Windows.Forms.RadioButton();
            this.labelJenisKelamin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamaLengkap = new System.Windows.Forms.Label();
            this.buttondataPribadi = new System.Windows.Forms.Button();
            this.panelFormBiodata = new System.Windows.Forms.Panel();
            this.panelDataPribadi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelFormBiodata.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataPribadi
            // 
            this.panelDataPribadi.Controls.Add(this.buttonRiwayat);
            this.panelDataPribadi.Controls.Add(this.dataGridView1);
            this.panelDataPribadi.Controls.Add(this.textBoxAlamat);
            this.panelDataPribadi.Controls.Add(this.textBoxTempatLahir);
            this.panelDataPribadi.Controls.Add(this.textBoxUsername);
            this.panelDataPribadi.Controls.Add(this.textBoxNamaLengkap);
            this.panelDataPribadi.Controls.Add(this.dateTimePicker1);
            this.panelDataPribadi.Controls.Add(this.labelTanggalLahir);
            this.panelDataPribadi.Controls.Add(this.labelAlamat);
            this.panelDataPribadi.Controls.Add(this.labelTempatLahir);
            this.panelDataPribadi.Controls.Add(this.radioButtonPerempuan);
            this.panelDataPribadi.Controls.Add(this.radioButtonLakiLaki);
            this.panelDataPribadi.Controls.Add(this.labelJenisKelamin);
            this.panelDataPribadi.Controls.Add(this.label1);
            this.panelDataPribadi.Controls.Add(this.labelNamaLengkap);
            this.panelDataPribadi.Controls.Add(this.buttondataPribadi);
            this.panelDataPribadi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataPribadi.Location = new System.Drawing.Point(0, 0);
            this.panelDataPribadi.Name = "panelDataPribadi";
            this.panelDataPribadi.Size = new System.Drawing.Size(700, 348);
            this.panelDataPribadi.TabIndex = 0;
            // 
            // buttonRiwayat
            // 
            this.buttonRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonRiwayat.FlatAppearance.BorderSize = 0;
            this.buttonRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRiwayat.ForeColor = System.Drawing.Color.White;
            this.buttonRiwayat.Location = new System.Drawing.Point(335, 42);
            this.buttonRiwayat.Name = "buttonRiwayat";
            this.buttonRiwayat.Size = new System.Drawing.Size(139, 30);
            this.buttonRiwayat.TabIndex = 16;
            this.buttonRiwayat.Text = "Riwayat Pelanggaran";
            this.buttonRiwayat.UseVisualStyleBackColor = false;
            this.buttonRiwayat.Click += new System.EventHandler(this.buttonRiwayat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 186);
            this.dataGridView1.TabIndex = 8;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(99, 192);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(200, 71);
            this.textBoxAlamat.TabIndex = 9;
            this.textBoxAlamat.TextChanged += new System.EventHandler(this.textBoxTempatLahir_TextChanged);
            // 
            // textBoxTempatLahir
            // 
            this.textBoxTempatLahir.Location = new System.Drawing.Point(99, 140);
            this.textBoxTempatLahir.Name = "textBoxTempatLahir";
            this.textBoxTempatLahir.Size = new System.Drawing.Size(200, 20);
            this.textBoxTempatLahir.TabIndex = 9;
            this.textBoxTempatLahir.TextChanged += new System.EventHandler(this.textBoxTempatLahir_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Location = new System.Drawing.Point(99, 41);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxNamaLengkap_TextChanged);
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(99, 66);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(200, 20);
            this.textBoxNamaLengkap.TabIndex = 8;
            this.textBoxNamaLengkap.TextChanged += new System.EventHandler(this.textBoxNamaLengkap_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Location = new System.Drawing.Point(13, 172);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(72, 13);
            this.labelTanggalLahir.TabIndex = 6;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(15, 195);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(84, 13);
            this.labelAlamat.TabIndex = 5;
            this.labelAlamat.Text = "Alamat Lengkap";
            // 
            // labelTempatLahir
            // 
            this.labelTempatLahir.AutoSize = true;
            this.labelTempatLahir.Location = new System.Drawing.Point(13, 143);
            this.labelTempatLahir.Name = "labelTempatLahir";
            this.labelTempatLahir.Size = new System.Drawing.Size(69, 13);
            this.labelTempatLahir.TabIndex = 5;
            this.labelTempatLahir.Text = "Tempat Lahir";
            // 
            // radioButtonPerempuan
            // 
            this.radioButtonPerempuan.AutoSize = true;
            this.radioButtonPerempuan.Location = new System.Drawing.Point(99, 117);
            this.radioButtonPerempuan.Name = "radioButtonPerempuan";
            this.radioButtonPerempuan.Size = new System.Drawing.Size(79, 17);
            this.radioButtonPerempuan.TabIndex = 4;
            this.radioButtonPerempuan.TabStop = true;
            this.radioButtonPerempuan.Text = "Perempuan";
            this.radioButtonPerempuan.UseVisualStyleBackColor = true;
            this.radioButtonPerempuan.CheckedChanged += new System.EventHandler(this.radioButtonPerempuan_CheckedChanged);
            // 
            // radioButtonLakiLaki
            // 
            this.radioButtonLakiLaki.AutoSize = true;
            this.radioButtonLakiLaki.Location = new System.Drawing.Point(99, 92);
            this.radioButtonLakiLaki.Name = "radioButtonLakiLaki";
            this.radioButtonLakiLaki.Size = new System.Drawing.Size(64, 17);
            this.radioButtonLakiLaki.TabIndex = 3;
            this.radioButtonLakiLaki.TabStop = true;
            this.radioButtonLakiLaki.Text = "Laki-laki";
            this.radioButtonLakiLaki.UseVisualStyleBackColor = true;
            this.radioButtonLakiLaki.CheckedChanged += new System.EventHandler(this.radioButtonLakiLaki_CheckedChanged);
            // 
            // labelJenisKelamin
            // 
            this.labelJenisKelamin.AutoSize = true;
            this.labelJenisKelamin.Location = new System.Drawing.Point(13, 94);
            this.labelJenisKelamin.Name = "labelJenisKelamin";
            this.labelJenisKelamin.Size = new System.Drawing.Size(71, 13);
            this.labelJenisKelamin.TabIndex = 2;
            this.labelJenisKelamin.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // labelNamaLengkap
            // 
            this.labelNamaLengkap.AutoSize = true;
            this.labelNamaLengkap.Location = new System.Drawing.Point(13, 69);
            this.labelNamaLengkap.Name = "labelNamaLengkap";
            this.labelNamaLengkap.Size = new System.Drawing.Size(80, 13);
            this.labelNamaLengkap.TabIndex = 1;
            this.labelNamaLengkap.Text = "Nama Lengkap";
            // 
            // buttondataPribadi
            // 
            this.buttondataPribadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(121)))), ((int)(((byte)(32)))));
            this.buttondataPribadi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttondataPribadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondataPribadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondataPribadi.ForeColor = System.Drawing.Color.White;
            this.buttondataPribadi.Location = new System.Drawing.Point(0, 0);
            this.buttondataPribadi.Name = "buttondataPribadi";
            this.buttondataPribadi.Size = new System.Drawing.Size(700, 36);
            this.buttondataPribadi.TabIndex = 0;
            this.buttondataPribadi.Text = "   Data Pribadi";
            this.buttondataPribadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondataPribadi.UseVisualStyleBackColor = false;
            // 
            // panelFormBiodata
            // 
            this.panelFormBiodata.Controls.Add(this.panelDataPribadi);
            this.panelFormBiodata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormBiodata.Location = new System.Drawing.Point(0, 0);
            this.panelFormBiodata.Name = "panelFormBiodata";
            this.panelFormBiodata.Size = new System.Drawing.Size(700, 348);
            this.panelFormBiodata.TabIndex = 4;
            this.panelFormBiodata.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormBiodata_Paint);
            // 
            // Form5Biodata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 348);
            this.Controls.Add(this.panelFormBiodata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5Biodata";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form5Biodata_Load);
            this.panelDataPribadi.ResumeLayout(false);
            this.panelDataPribadi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelFormBiodata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDataPribadi;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxTempatLahir;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelTempatLahir;
        private System.Windows.Forms.RadioButton radioButtonPerempuan;
        private System.Windows.Forms.RadioButton radioButtonLakiLaki;
        private System.Windows.Forms.Label labelJenisKelamin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamaLengkap;
        private System.Windows.Forms.Button buttondataPribadi;
        private System.Windows.Forms.Panel panelFormBiodata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRiwayat;
    }
}