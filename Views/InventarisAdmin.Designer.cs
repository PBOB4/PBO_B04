namespace TeaSMart_App.Views
{
    partial class InventarisAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarisAdmin));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMenu = new PictureBox();
            panel2 = new Panel();
            buttonHalamanUtama = new Button();
            panel3 = new Panel();
            btnHInventaris = new Button();
            panel4 = new Panel();
            btnRiwayatTransaksi = new Button();
            panel5 = new Panel();
            btnPengaturan = new Button();
            panel6 = new Panel();
            btnLogout = new Button();
            panel7 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            pictureBox9 = new PictureBox();
            flyDisplayProduct = new FlowLayoutPanel();
            panel8 = new Panel();
            label1 = new Label();
            btnCO = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(153, 178, 127);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(267, 721);
            sidebar.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 236);
            panel2.Controls.Add(buttonHalamanUtama);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 65);
            panel2.TabIndex = 6;
            // 
            // buttonHalamanUtama
            // 
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
            buttonHalamanUtama.UseVisualStyleBackColor = true;
            buttonHalamanUtama.Click += buttonHalamanUtama_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnHInventaris);
            panel3.Location = new Point(3, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 65);
            panel3.TabIndex = 7;
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
            // panel4
            // 
            panel4.Controls.Add(btnRiwayatTransaksi);
            panel4.Location = new Point(3, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 65);
            panel4.TabIndex = 8;
            // 
            // btnRiwayatTransaksi
            // 
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
            btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPengaturan);
            panel5.Location = new Point(3, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 65);
            panel5.TabIndex = 9;
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
            // panel6
            // 
            panel6.Controls.Add(btnLogout);
            panel6.Location = new Point(3, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 65);
            panel6.TabIndex = 10;
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
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(181, 199, 156);
            panel7.Controls.Add(btnSearch);
            panel7.Controls.Add(txtSearch);
            panel7.Controls.Add(pictureBox9);
            panel7.Location = new Point(15, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(883, 63);
            panel7.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(157, 181, 132);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(7, 43, 0);
            btnSearch.Location = new Point(773, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(157, 181, 132);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(55, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(727, 36);
            txtSearch.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(11, 11);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 38);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // flyDisplayProduct
            // 
            flyDisplayProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flyDisplayProduct.AutoScroll = true;
            flyDisplayProduct.BackColor = Color.Transparent;
            flyDisplayProduct.Location = new Point(3, 110);
            flyDisplayProduct.Name = "flyDisplayProduct";
            flyDisplayProduct.Size = new Size(1069, 518);
            flyDisplayProduct.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.AutoScroll = true;
            panel8.AutoSize = true;
            panel8.BackgroundImage = Properties.Resources.pbo_background_2__1_;
            panel8.Controls.Add(label1);
            panel8.Controls.Add(btnCO);
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(flyDisplayProduct);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(267, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1081, 721);
            panel8.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(909, 64);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // btnCO
            // 
            btnCO.BackColor = Color.FromArgb(8, 51, 0);
            btnCO.Cursor = Cursors.Hand;
            btnCO.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCO.ForeColor = Color.White;
            btnCO.Location = new Point(909, 663);
            btnCO.Name = "btnCO";
            btnCO.Size = new Size(145, 46);
            btnCO.TabIndex = 8;
            btnCO.Text = "Check Out";
            btnCO.UseVisualStyleBackColor = false;
            btnCO.Click += btnCO_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // InventarisAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel8);
            Controls.Add(sidebar);
            ForeColor = Color.FromArgb(7, 43, 0);
            Name = "InventarisAdmin";
            Text = "InventarisAdmin";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox btnMenu;
        private PictureBox pictureBox3;
        private Panel panel7;
        private PictureBox pictureBox9;
        private FlowLayoutPanel flyDisplayProduct;
        private Panel panel8;
        private System.Windows.Forms.Timer sidebartimer;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnCO;
        private Label label1;
        private Panel panel2;
        private Button buttonHalamanUtama;
        private Panel panel3;
        private Button btnHInventaris;
        private Panel panel4;
        private Button btnRiwayatTransaksi;
        private Panel panel5;
        private Button btnPengaturan;
        private Panel panel6;
        private Button btnLogout;
    }
}