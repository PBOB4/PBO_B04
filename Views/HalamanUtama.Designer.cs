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
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel9 = new Panel();
            panel10 = new Panel();
            lblQuotes = new Label();
            label3 = new Label();
            btnRefresh = new PictureBox();
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
            flowLayoutPanel1.SuspendLayout();
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
            sidebar.Paint += sidebar_Paint;
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
            panel2.Paint += panel2_Paint;
            // 
            // buttonHalamanUtama
            // 
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
            buttonHalamanUtama.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 65);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(270, 65);
            button2.TabIndex = 1;
            button2.Text = "              Inventaris Produk";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 65);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 64, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-3, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(270, 65);
            button3.TabIndex = 1;
            button3.Text = "              Transaksi";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 65);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(0, 64, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(270, 65);
            button4.TabIndex = 1;
            button4.Text = "              Pengaturan";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 65);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(0, 64, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-3, 0);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(270, 65);
            button5.TabIndex = 1;
            button5.Text = "              Log Out";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 255, 236);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Location = new Point(539, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(410, 553);
            flowLayoutPanel1.TabIndex = 3;
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
            panel7.Paint += panel7_Paint_1;
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
            label1.Click += label1_Click;
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
            pictureBox5.Location = new Point(37, 25);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(467, 334);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(153, 178, 127);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(pictureBox5);
            panel9.Controls.Add(flowLayoutPanel1);
            panel9.Location = new Point(314, 54);
            panel9.Name = "panel9";
            panel9.Size = new Size(983, 618);
            panel9.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 255, 235);
            panel10.Controls.Add(lblQuotes);
            panel10.Controls.Add(label3);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(22, 12);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 1;
            label3.Text = "T'day Quote:";
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
            // HalamanUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1348, 721);
            Controls.Add(panel9);
            Controls.Add(sidebar);
            ForeColor = Color.DarkCyan;
            Name = "HalamanUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
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
            flowLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button buttonHalamanUtama;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Panel panel8;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox5;
        private Panel panel9;
        private Panel panel10;
        private PictureBox btnRefresh;
        private Label label3;
        private Label lblQuotes;
    }
}
