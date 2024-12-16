namespace TeaSMart_App.Views
{
    partial class Settings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMenu = new PictureBox();
            panel3 = new Panel();
            buttonHalamanUtama = new Button();
            panel4 = new Panel();
            btnHInventaris = new Button();
            panel5 = new Panel();
            btnRiwayatTransaksi = new Button();
            panel6 = new Panel();
            btnPengaturan = new Button();
            panel2 = new Panel();
            btnLogout = new Button();
            panel7 = new Panel();
            linkUbahPw = new Label();
            lblUsnUser = new Label();
            lblNamaUser = new Label();
            lblHeader = new Label();
            panel8 = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(153, 178, 127);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(267, 721);
            sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 78);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(206, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(18, 18);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(33, 33);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 236);
            panel3.Controls.Add(buttonHalamanUtama);
            panel3.Location = new Point(3, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 65);
            panel3.TabIndex = 16;
            // 
            // buttonHalamanUtama
            // 
            buttonHalamanUtama.BackColor = Color.FromArgb(153, 178, 127);
            buttonHalamanUtama.Cursor = Cursors.Hand;
            buttonHalamanUtama.FlatStyle = FlatStyle.Flat;
            buttonHalamanUtama.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHalamanUtama.ForeColor = Color.FromArgb(0, 64, 0);
            buttonHalamanUtama.Image = (Image)resources.GetObject("buttonHalamanUtama.Image");
            buttonHalamanUtama.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHalamanUtama.Location = new Point(-3, 0);
            buttonHalamanUtama.Name = "buttonHalamanUtama";
            buttonHalamanUtama.Padding = new Padding(30, 0, 0, 0);
            buttonHalamanUtama.Size = new Size(270, 65);
            buttonHalamanUtama.TabIndex = 1;
            buttonHalamanUtama.Text = "              Halaman Utama";
            buttonHalamanUtama.TextAlign = ContentAlignment.MiddleLeft;
            buttonHalamanUtama.UseVisualStyleBackColor = false;
            buttonHalamanUtama.Click += buttonHalamanUtama_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnHInventaris);
            panel4.Location = new Point(3, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 65);
            panel4.TabIndex = 17;
            // 
            // btnHInventaris
            // 
            btnHInventaris.Cursor = Cursors.Hand;
            btnHInventaris.FlatStyle = FlatStyle.Flat;
            btnHInventaris.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHInventaris.ForeColor = Color.FromArgb(0, 64, 0);
            btnHInventaris.Image = (Image)resources.GetObject("btnHInventaris.Image");
            btnHInventaris.ImageAlign = ContentAlignment.MiddleLeft;
            btnHInventaris.Location = new Point(-3, 0);
            btnHInventaris.Name = "btnHInventaris";
            btnHInventaris.Padding = new Padding(30, 0, 0, 0);
            btnHInventaris.Size = new Size(270, 65);
            btnHInventaris.TabIndex = 1;
            btnHInventaris.Text = "              Inventaris Produk";
            btnHInventaris.TextAlign = ContentAlignment.MiddleLeft;
            btnHInventaris.UseVisualStyleBackColor = true;
            btnHInventaris.Click += btnHInventaris_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRiwayatTransaksi);
            panel5.Location = new Point(3, 229);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 65);
            panel5.TabIndex = 18;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.FromArgb(255, 255, 235);
            btnRiwayatTransaksi.Cursor = Cursors.Hand;
            btnRiwayatTransaksi.FlatStyle = FlatStyle.Flat;
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.ForeColor = Color.FromArgb(0, 64, 0);
            btnRiwayatTransaksi.Image = (Image)resources.GetObject("btnRiwayatTransaksi.Image");
            btnRiwayatTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTransaksi.Location = new Point(-3, 0);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Padding = new Padding(30, 0, 0, 0);
            btnRiwayatTransaksi.Size = new Size(270, 65);
            btnRiwayatTransaksi.TabIndex = 1;
            btnRiwayatTransaksi.Text = "              Riwayat Transaksi";
            btnRiwayatTransaksi.TextAlign = ContentAlignment.MiddleLeft;
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnPengaturan);
            panel6.Location = new Point(3, 300);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 65);
            panel6.TabIndex = 19;
            // 
            // btnPengaturan
            // 
            btnPengaturan.Cursor = Cursors.Hand;
            btnPengaturan.FlatStyle = FlatStyle.Flat;
            btnPengaturan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengaturan.ForeColor = Color.FromArgb(0, 64, 0);
            btnPengaturan.Image = (Image)resources.GetObject("btnPengaturan.Image");
            btnPengaturan.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengaturan.Location = new Point(-3, 0);
            btnPengaturan.Name = "btnPengaturan";
            btnPengaturan.Padding = new Padding(30, 0, 0, 0);
            btnPengaturan.Size = new Size(270, 65);
            btnPengaturan.TabIndex = 1;
            btnPengaturan.Text = "              Pengaturan";
            btnPengaturan.TextAlign = ContentAlignment.MiddleLeft;
            btnPengaturan.UseVisualStyleBackColor = true;
            btnPengaturan.Click += btnPengaturan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(3, 371);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 65);
            panel2.TabIndex = 20;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.FromArgb(0, 64, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(-3, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(30, 0, 0, 0);
            btnLogout.Size = new Size(270, 65);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "              Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 255, 235);
            panel7.Controls.Add(linkUbahPw);
            panel7.Controls.Add(lblUsnUser);
            panel7.Controls.Add(lblNamaUser);
            panel7.Location = new Point(553, 105);
            panel7.Name = "panel7";
            panel7.Size = new Size(531, 296);
            panel7.TabIndex = 2;
            // 
            // linkUbahPw
            // 
            linkUbahPw.AutoSize = true;
            linkUbahPw.Cursor = Cursors.Hand;
            linkUbahPw.ForeColor = SystemColors.HotTrack;
            linkUbahPw.Location = new Point(37, 212);
            linkUbahPw.Name = "linkUbahPw";
            linkUbahPw.Size = new Size(122, 20);
            linkUbahPw.TabIndex = 3;
            linkUbahPw.Text = "Ubah Password ...";
            linkUbahPw.Click += linkUbahPw_Click;
            // 
            // lblUsnUser
            // 
            lblUsnUser.AutoSize = true;
            lblUsnUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsnUser.Location = new Point(37, 162);
            lblUsnUser.Name = "lblUsnUser";
            lblUsnUser.Size = new Size(106, 20);
            lblUsnUser.TabIndex = 2;
            lblUsnUser.Text = "Username      :";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaUser.Location = new Point(37, 118);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(106, 20);
            lblNamaUser.TabIndex = 1;
            lblNamaUser.Text = "Nama             :";
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(16, 13);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(500, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Informasi Akun @username";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(153, 178, 127);
            panel8.Controls.Add(lblHeader);
            panel8.Location = new Point(553, 105);
            panel8.Name = "panel8";
            panel8.Size = new Size(531, 72);
            panel8.TabIndex = 6;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1348, 721);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox btnMenu;
        private Panel panel7;
        private Label linkUbahPw;
        private Label lblUsnUser;
        private Label lblNamaUser;
        private Label lblHeader;
        private Panel panel8;
        private Panel panel3;
        private Button buttonHalamanUtama;
        private Panel panel4;
        private Button btnHInventaris;
        private Panel panel5;
        private Button btnRiwayatTransaksi;
        private Panel panel6;
        private Button btnPengaturan;
        private Panel panel2;
        private Button btnLogout;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}