namespace TeaSMart_App.Views
{
    partial class HalamanUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanUtama));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            menuButton = new PictureBox();
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
            sidebarTimer = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            flyRank = new FlowLayoutPanel();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel9 = new Panel();
            label4 = new Label();
            panel10 = new Panel();
            lblQuotes = new Label();
            lblHeaderQuote = new Label();
            btnRefresh = new PictureBox();
            lblWelcome = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            flyRank.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
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
            sidebar.MaximumSize = new Size(267, 721);
            sidebar.MinimumSize = new Size(103, 721);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(267, 721);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 178, 127);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 78);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(218, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(20, 18);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(51, 44);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 236);
            panel2.Controls.Add(buttonHalamanUtama);
            panel2.Location = new Point(3, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 65);
            panel2.TabIndex = 1;
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
            panel3.TabIndex = 2;
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
            panel4.TabIndex = 3;
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
            panel5.TabIndex = 4;
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
            panel6.TabIndex = 5;
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
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // flyRank
            // 
            flyRank.AutoScroll = true;
            flyRank.BackColor = Color.FromArgb(255, 255, 236);
            flyRank.Controls.Add(panel7);
            flyRank.Location = new Point(539, 68);
            flyRank.Name = "flyRank";
            flyRank.Size = new Size(410, 510);
            flyRank.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(153, 178, 127);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(50, 50);
            panel7.Margin = new Padding(50);
            panel7.Name = "panel7";
            panel7.Size = new Size(322, 124);
            panel7.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(150, 57);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Rp.40000.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(147, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 17);
            label1.TabIndex = 2;
            label1.Text = "Teh Kurma Limited Edition";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 255, 236);
            panel8.Location = new Point(43, 13);
            panel8.Name = "panel8";
            panel8.Size = new Size(101, 97);
            panel8.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(37, 30);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(467, 329);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(153, 178, 127);
            panel9.Controls.Add(label4);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(flyRank);
            panel9.Location = new Point(314, 87);
            panel9.Name = "panel9";
            panel9.Size = new Size(983, 618);
            panel9.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 64, 0);
            label4.Location = new Point(667, 30);
            label4.Name = "label4";
            label4.Size = new Size(185, 28);
            label4.TabIndex = 6;
            label4.Text = "Customers' Choice";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 255, 235);
            panel10.Controls.Add(lblQuotes);
            panel10.Controls.Add(lblHeaderQuote);
            panel10.Controls.Add(btnRefresh);
            panel10.ForeColor = Color.FromArgb(255, 192, 192);
            panel10.Location = new Point(37, 378);
            panel10.Name = "panel10";
            panel10.Size = new Size(467, 200);
            panel10.TabIndex = 5;
            // 
            // lblQuotes
            // 
            lblQuotes.AllowDrop = true;
            lblQuotes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblQuotes.ForeColor = Color.FromArgb(0, 64, 0);
            lblQuotes.Location = new Point(22, 49);
            lblQuotes.Name = "lblQuotes";
            lblQuotes.Size = new Size(427, 133);
            lblQuotes.TabIndex = 2;
            lblQuotes.Text = "Quotes";
            // 
            // lblHeaderQuote
            // 
            lblHeaderQuote.AutoSize = true;
            lblHeaderQuote.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblHeaderQuote.ForeColor = Color.FromArgb(0, 64, 0);
            lblHeaderQuote.Location = new Point(22, 12);
            lblHeaderQuote.Name = "lblHeaderQuote";
            lblHeaderQuote.Size = new Size(133, 28);
            lblHeaderQuote.TabIndex = 1;
            lblHeaderQuote.Text = "T'day Quote:";
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(425, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(24, 24);
            btnRefresh.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRefresh.TabIndex = 0;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(0, 64, 0);
            lblWelcome.Location = new Point(591, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(411, 38);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Have a Joyful Teatime, Users!";
            // 
            // HalamanUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblWelcome);
            Controls.Add(panel9);
            Controls.Add(sidebar);
            ForeColor = Color.DarkCyan;
            Name = "HalamanUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HalamanUtama_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            flyRank.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
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
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel flyRank;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox5;
        private Panel panel9;
        private Panel panel10;
        private PictureBox btnRefresh;
        private Label lblHeaderQuote;
        private Label lblQuotes;
        private Label label4;
        private Label lblWelcome;
    }
}
