namespace WindowsFormsProject
{
    partial class Form6Admin
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
            this.labelLupaPassword = new System.Windows.Forms.Label();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.buttonCatat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.buttonSimpanPelanggaran = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonRiwayat = new System.Windows.Forms.Button();
            this.buttonTingkatPelanggaran = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLupaPassword
            // 
            this.labelLupaPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLupaPassword.AutoSize = true;
            this.labelLupaPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelLupaPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLupaPassword.ForeColor = System.Drawing.Color.White;
            this.labelLupaPassword.Location = new System.Drawing.Point(69, 70);
            this.labelLupaPassword.Name = "labelLupaPassword";
            this.labelLupaPassword.Size = new System.Drawing.Size(270, 29);
            this.labelLupaPassword.TabIndex = 25;
            this.labelLupaPassword.Text = "DAFTAR PENGGUNA";
            // 
            // buttonProfil
            // 
            this.buttonProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonProfil.FlatAppearance.BorderSize = 0;
            this.buttonProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfil.ForeColor = System.Drawing.Color.White;
            this.buttonProfil.Location = new System.Drawing.Point(74, 119);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.Size = new System.Drawing.Size(136, 30);
            this.buttonProfil.TabIndex = 6;
            this.buttonProfil.Text = "Tampilkan Profil";
            this.buttonProfil.UseVisualStyleBackColor = false;
            this.buttonProfil.Click += new System.EventHandler(this.buttonProfil_Click);
            // 
            // buttonCatat
            // 
            this.buttonCatat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonCatat.FlatAppearance.BorderSize = 0;
            this.buttonCatat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatat.ForeColor = System.Drawing.Color.White;
            this.buttonCatat.Location = new System.Drawing.Point(216, 119);
            this.buttonCatat.Name = "buttonCatat";
            this.buttonCatat.Size = new System.Drawing.Size(139, 30);
            this.buttonCatat.TabIndex = 6;
            this.buttonCatat.Text = "Catat Pelanggaran";
            this.buttonCatat.UseVisualStyleBackColor = false;
            this.buttonCatat.Click += new System.EventHandler(this.buttonCatat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(102, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Terlambat 5-15 menit";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Jenis Pelanggaran";
            this.label1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(102, 225);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Tanpa keterangan (alpha)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox3.Location = new System.Drawing.Point(102, 248);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(218, 17);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "Memakai kaos oblong selain warna putih";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox4.Location = new System.Drawing.Point(102, 271);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(245, 17);
            this.checkBox4.TabIndex = 27;
            this.checkBox4.Text = "Peserta didik pria berambut panjang/gondrong";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox5.Location = new System.Drawing.Point(102, 294);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(170, 17);
            this.checkBox5.TabIndex = 27;
            this.checkBox5.Text = "Menyontek saat ulangan/ujian";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // buttonSimpanPelanggaran
            // 
            this.buttonSimpanPelanggaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonSimpanPelanggaran.FlatAppearance.BorderSize = 0;
            this.buttonSimpanPelanggaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimpanPelanggaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpanPelanggaran.ForeColor = System.Drawing.Color.White;
            this.buttonSimpanPelanggaran.Location = new System.Drawing.Point(373, 313);
            this.buttonSimpanPelanggaran.Name = "buttonSimpanPelanggaran";
            this.buttonSimpanPelanggaran.Size = new System.Drawing.Size(73, 28);
            this.buttonSimpanPelanggaran.TabIndex = 9;
            this.buttonSimpanPelanggaran.Text = "Simpan";
            this.buttonSimpanPelanggaran.UseVisualStyleBackColor = false;
            this.buttonSimpanPelanggaran.Visible = false;
            this.buttonSimpanPelanggaran.Click += new System.EventHandler(this.buttonSimpanPelanggaran_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(95, 161);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(80, 16);
            this.labelUsername.TabIndex = 25;
            this.labelUsername.Text = "Username";
            this.labelUsername.Visible = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(194, 159);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(153, 20);
            this.textBoxUsername.TabIndex = 28;
            this.textBoxUsername.Visible = false;
            // 
            // buttonRiwayat
            // 
            this.buttonRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonRiwayat.FlatAppearance.BorderSize = 0;
            this.buttonRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRiwayat.ForeColor = System.Drawing.Color.White;
            this.buttonRiwayat.Location = new System.Drawing.Point(361, 119);
            this.buttonRiwayat.Name = "buttonRiwayat";
            this.buttonRiwayat.Size = new System.Drawing.Size(139, 30);
            this.buttonRiwayat.TabIndex = 6;
            this.buttonRiwayat.Text = "Riwayat Pelanggaran";
            this.buttonRiwayat.UseVisualStyleBackColor = false;
            this.buttonRiwayat.Click += new System.EventHandler(this.buttonRiwayat_Click);
            // 
            // buttonTingkatPelanggaran
            // 
            this.buttonTingkatPelanggaran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonTingkatPelanggaran.FlatAppearance.BorderSize = 0;
            this.buttonTingkatPelanggaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTingkatPelanggaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTingkatPelanggaran.ForeColor = System.Drawing.Color.White;
            this.buttonTingkatPelanggaran.Location = new System.Drawing.Point(506, 119);
            this.buttonTingkatPelanggaran.Name = "buttonTingkatPelanggaran";
            this.buttonTingkatPelanggaran.Size = new System.Drawing.Size(139, 30);
            this.buttonTingkatPelanggaran.TabIndex = 6;
            this.buttonTingkatPelanggaran.Text = "Tingkat Pelanggaran";
            this.buttonTingkatPelanggaran.UseVisualStyleBackColor = false;
            this.buttonTingkatPelanggaran.Click += new System.EventHandler(this.buttonTingkatPelanggaran_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 186);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form6Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(720, 404);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLupaPassword);
            this.Controls.Add(this.buttonSimpanPelanggaran);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTingkatPelanggaran);
            this.Controls.Add(this.buttonRiwayat);
            this.Controls.Add(this.buttonCatat);
            this.Controls.Add(this.buttonProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6Admin";
            this.Text = "Form6Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLupaPassword;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.Button buttonCatat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button buttonSimpanPelanggaran;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonRiwayat;
        private System.Windows.Forms.Button buttonTingkatPelanggaran;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}