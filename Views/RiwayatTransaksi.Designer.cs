namespace TeaSMart_App.Views
{
    partial class RiwayatTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatTransaksi));
            panel1 = new Panel();
            dataGridRiwayat = new DataGridView();
            label1 = new Label();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            btnMenu = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            buttonHalamanUtama = new Button();
            panel4 = new Panel();
            btnHInventaris = new Button();
            panel5 = new Panel();
            btnRiwayatTransaksi = new Button();
            panel6 = new Panel();
            btnPengaturan = new Button();
            panel7 = new Panel();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRiwayat).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 235);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dataGridRiwayat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sidebar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 721);
            panel1.TabIndex = 0;
            // 
            // dataGridRiwayat
            // 
            dataGridRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRiwayat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridRiwayat.BackgroundColor = Color.FromArgb(153, 178, 127);
            dataGridRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRiwayat.GridColor = Color.FromArgb(255, 255, 235);
            dataGridRiwayat.Location = new Point(314, 50);
            dataGridRiwayat.Name = "dataGridRiwayat";
            dataGridRiwayat.ReadOnly = true;
            dataGridRiwayat.RowHeadersWidth = 50;
            dataGridRiwayat.Size = new Size(988, 646);
            dataGridRiwayat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 17);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 2;
            label1.Text = "Riwayat Transaksi";
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(153, 178, 127);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(275, 721);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 178, 127);
            panel2.Controls.Add(btnMenu);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 78);
            panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(23, 25);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(33, 33);
            btnMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(77, 37);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(118, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(208, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 255, 236);
            panel3.Controls.Add(buttonHalamanUtama);
            panel3.Location = new Point(3, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 65);
            panel3.TabIndex = 11;
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
            panel4.TabIndex = 12;
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
            panel5.TabIndex = 13;
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
            panel6.TabIndex = 14;
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
            // panel7
            // 
            panel7.Controls.Add(btnLogout);
            panel7.Location = new Point(3, 371);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 65);
            panel7.TabIndex = 15;
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
            // sidebarTimer
            // 
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel1);
            Name = "RiwayatTransaksi";
            Text = "TransaksiOwner";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridRiwayat).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel sidebar;
        private DataGridView dataGridRiwayat;
        private Label label1;
        private Panel panel3;
        private Button buttonHalamanUtama;
        private Panel panel4;
        private Button btnHInventaris;
        private Panel panel5;
        private Button btnRiwayatTransaksi;
        private Panel panel6;
        private Button btnPengaturan;
        private Panel panel7;
        private Button btnLogout;
        private Panel panel2;
        private PictureBox btnMenu;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}