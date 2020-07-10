namespace WindowsFormsProject
{
    partial class Form1Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Container));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBoxIdentitasBeasiswa = new System.Windows.Forms.PictureBox();
            this.buttonCMasuk = new System.Windows.Forms.Button();
            this.buttonCSyarat = new System.Windows.Forms.Button();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.labelNamaBeasiswa = new System.Windows.Forms.Label();
            this.buttonMinimized = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.buttonCBeranda = new System.Windows.Forms.Button();
            this.buttoncKeluar = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentitasBeasiswa)).BeginInit();
            this.panelAtas.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.pictureBoxIdentitasBeasiswa);
            this.panelContainer.Location = new System.Drawing.Point(172, 33);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(682, 400);
            this.panelContainer.TabIndex = 0;
            // 
            // pictureBoxIdentitasBeasiswa
            // 
            this.pictureBoxIdentitasBeasiswa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIdentitasBeasiswa.BackgroundImage")));
            this.pictureBoxIdentitasBeasiswa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxIdentitasBeasiswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIdentitasBeasiswa.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIdentitasBeasiswa.Name = "pictureBoxIdentitasBeasiswa";
            this.pictureBoxIdentitasBeasiswa.Size = new System.Drawing.Size(680, 398);
            this.pictureBoxIdentitasBeasiswa.TabIndex = 4;
            this.pictureBoxIdentitasBeasiswa.TabStop = false;
            // 
            // buttonCMasuk
            // 
            this.buttonCMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonCMasuk.FlatAppearance.BorderSize = 0;
            this.buttonCMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.buttonCMasuk.Location = new System.Drawing.Point(4, 200);
            this.buttonCMasuk.Name = "buttonCMasuk";
            this.buttonCMasuk.Size = new System.Drawing.Size(165, 56);
            this.buttonCMasuk.TabIndex = 0;
            this.buttonCMasuk.Text = "Masuk";
            this.buttonCMasuk.UseVisualStyleBackColor = false;
            this.buttonCMasuk.Click += new System.EventHandler(this.buttonCMasuk_Click);
            // 
            // buttonCSyarat
            // 
            this.buttonCSyarat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonCSyarat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCSyarat.FlatAppearance.BorderSize = 0;
            this.buttonCSyarat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCSyarat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSyarat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.buttonCSyarat.Location = new System.Drawing.Point(4, 138);
            this.buttonCSyarat.Name = "buttonCSyarat";
            this.buttonCSyarat.Size = new System.Drawing.Size(165, 56);
            this.buttonCSyarat.TabIndex = 0;
            this.buttonCSyarat.Text = "Peraturan";
            this.buttonCSyarat.UseVisualStyleBackColor = false;
            this.buttonCSyarat.Click += new System.EventHandler(this.buttonCSyarat_Click);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelAtas.Controls.Add(this.labelNamaBeasiswa);
            this.panelAtas.Controls.Add(this.buttonMinimized);
            this.panelAtas.Controls.Add(this.buttonClose);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(854, 33);
            this.panelAtas.TabIndex = 1;
            this.panelAtas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAtas_MouseDown);
            // 
            // labelNamaBeasiswa
            // 
            this.labelNamaBeasiswa.AutoSize = true;
            this.labelNamaBeasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBeasiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.labelNamaBeasiswa.Location = new System.Drawing.Point(4, 6);
            this.labelNamaBeasiswa.Name = "labelNamaBeasiswa";
            this.labelNamaBeasiswa.Size = new System.Drawing.Size(114, 24);
            this.labelNamaBeasiswa.TabIndex = 1;
            this.labelNamaBeasiswa.Text = "SIPP SISWA";
            // 
            // buttonMinimized
            // 
            this.buttonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonMinimized.FlatAppearance.BorderSize = 0;
            this.buttonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimized.Location = new System.Drawing.Point(787, 0);
            this.buttonMinimized.Name = "buttonMinimized";
            this.buttonMinimized.Size = new System.Drawing.Size(33, 33);
            this.buttonMinimized.TabIndex = 0;
            this.buttonMinimized.Text = "_";
            this.buttonMinimized.UseVisualStyleBackColor = true;
            this.buttonMinimized.Click += new System.EventHandler(this.buttonMinimized_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(821, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(33, 33);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panelKiri.Controls.Add(this.buttonCBeranda);
            this.panelKiri.Controls.Add(this.buttonCSyarat);
            this.panelKiri.Controls.Add(this.buttoncKeluar);
            this.panelKiri.Controls.Add(this.buttonCMasuk);
            this.panelKiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKiri.Location = new System.Drawing.Point(0, 33);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(172, 400);
            this.panelKiri.TabIndex = 2;
            // 
            // buttonCBeranda
            // 
            this.buttonCBeranda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttonCBeranda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCBeranda.FlatAppearance.BorderSize = 0;
            this.buttonCBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCBeranda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCBeranda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.buttonCBeranda.Location = new System.Drawing.Point(4, 76);
            this.buttonCBeranda.Name = "buttonCBeranda";
            this.buttonCBeranda.Size = new System.Drawing.Size(165, 56);
            this.buttonCBeranda.TabIndex = 0;
            this.buttonCBeranda.Text = "Beranda";
            this.buttonCBeranda.UseVisualStyleBackColor = false;
            this.buttonCBeranda.Click += new System.EventHandler(this.buttonCBeranda_Click);
            // 
            // buttoncKeluar
            // 
            this.buttoncKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.buttoncKeluar.Enabled = false;
            this.buttoncKeluar.FlatAppearance.BorderSize = 0;
            this.buttoncKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.buttoncKeluar.Location = new System.Drawing.Point(4, 262);
            this.buttoncKeluar.Name = "buttoncKeluar";
            this.buttoncKeluar.Size = new System.Drawing.Size(165, 56);
            this.buttoncKeluar.TabIndex = 0;
            this.buttoncKeluar.Text = "Keluar";
            this.buttoncKeluar.UseVisualStyleBackColor = false;
            this.buttoncKeluar.Visible = false;
            this.buttoncKeluar.Click += new System.EventHandler(this.buttoncKeluar_Click);
            // 
            // Form1Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 433);
            this.Controls.Add(this.panelKiri);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form0Container";
            this.Load += new System.EventHandler(this.Form0Container_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdentitasBeasiswa)).EndInit();
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            this.panelKiri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCSyarat;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelKiri;
        private System.Windows.Forms.Button buttonMinimized;
        private System.Windows.Forms.Label labelNamaBeasiswa;
        private System.Windows.Forms.Button buttonCBeranda;
        public System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBoxIdentitasBeasiswa;
        public System.Windows.Forms.Button buttonCMasuk;
        public System.Windows.Forms.Button buttoncKeluar;
    }
}