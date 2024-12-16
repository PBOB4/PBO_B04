namespace TeaSMart_App.Views
{
    partial class UbahPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbahPassword));
            panel2 = new Panel();
            showConfirmPw = new CheckBox();
            lblKonfirmasi = new Label();
            lblPassBaru = new Label();
            lblPassLama = new Label();
            btnUbahPw = new Button();
            panel8 = new Panel();
            tbKonfirmasiPw = new TextBox();
            pictureBox9 = new PictureBox();
            panel7 = new Panel();
            pictureBox8 = new PictureBox();
            tbPwBaru = new TextBox();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            tbPwLama = new TextBox();
            btnBack = new PictureBox();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(showConfirmPw);
            panel2.Controls.Add(lblKonfirmasi);
            panel2.Controls.Add(lblPassBaru);
            panel2.Controls.Add(lblPassLama);
            panel2.Controls.Add(btnUbahPw);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(73, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 411);
            panel2.TabIndex = 1;
            // 
            // showConfirmPw
            // 
            showConfirmPw.AutoSize = true;
            showConfirmPw.BackColor = Color.Transparent;
            showConfirmPw.Location = new Point(332, 200);
            showConfirmPw.Name = "showConfirmPw";
            showConfirmPw.Size = new Size(68, 24);
            showConfirmPw.TabIndex = 12;
            showConfirmPw.Text = "Show";
            showConfirmPw.UseVisualStyleBackColor = false;
            showConfirmPw.CheckedChanged += showConfirmPw_CheckedChanged;
            // 
            // lblKonfirmasi
            // 
            lblKonfirmasi.AutoSize = true;
            lblKonfirmasi.BackColor = Color.Transparent;
            lblKonfirmasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKonfirmasi.ForeColor = Color.White;
            lblKonfirmasi.Location = new Point(35, 199);
            lblKonfirmasi.Name = "lblKonfirmasi";
            lblKonfirmasi.Size = new Size(202, 20);
            lblKonfirmasi.TabIndex = 11;
            lblKonfirmasi.Text = "Konfirmasi Ulang Password";
            // 
            // lblPassBaru
            // 
            lblPassBaru.AutoSize = true;
            lblPassBaru.BackColor = Color.Transparent;
            lblPassBaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassBaru.ForeColor = Color.White;
            lblPassBaru.Location = new Point(35, 114);
            lblPassBaru.Name = "lblPassBaru";
            lblPassBaru.Size = new Size(113, 20);
            lblPassBaru.TabIndex = 10;
            lblPassBaru.Text = "Password Baru";
            // 
            // lblPassLama
            // 
            lblPassLama.AutoSize = true;
            lblPassLama.BackColor = Color.Transparent;
            lblPassLama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassLama.ForeColor = Color.White;
            lblPassLama.Location = new Point(35, 31);
            lblPassLama.Name = "lblPassLama";
            lblPassLama.Size = new Size(118, 20);
            lblPassLama.TabIndex = 8;
            lblPassLama.Text = "Password Lama";
            // 
            // btnUbahPw
            // 
            btnUbahPw.BackColor = Color.FromArgb(103, 140, 65);
            btnUbahPw.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUbahPw.ForeColor = Color.White;
            btnUbahPw.Location = new Point(147, 310);
            btnUbahPw.Name = "btnUbahPw";
            btnUbahPw.Size = new Size(151, 45);
            btnUbahPw.TabIndex = 6;
            btnUbahPw.Text = "Ubah Password";
            btnUbahPw.UseVisualStyleBackColor = false;
            btnUbahPw.Click += btnUbahPw_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(tbKonfirmasiPw);
            panel8.Controls.Add(pictureBox9);
            panel8.Location = new Point(35, 222);
            panel8.Name = "panel8";
            panel8.Size = new Size(372, 47);
            panel8.TabIndex = 5;
            // 
            // tbKonfirmasiPw
            // 
            tbKonfirmasiPw.Cursor = Cursors.IBeam;
            tbKonfirmasiPw.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKonfirmasiPw.Location = new Point(69, 1);
            tbKonfirmasiPw.Name = "tbKonfirmasiPw";
            tbKonfirmasiPw.Size = new Size(304, 43);
            tbKonfirmasiPw.TabIndex = 0;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(15, 10);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 27);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 5;
            pictureBox9.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(pictureBox8);
            panel7.Controls.Add(tbPwBaru);
            panel7.Location = new Point(35, 137);
            panel7.Name = "panel7";
            panel7.Size = new Size(372, 47);
            panel7.TabIndex = 4;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(15, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 27);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // tbPwBaru
            // 
            tbPwBaru.Cursor = Cursors.IBeam;
            tbPwBaru.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPwBaru.Location = new Point(68, 1);
            tbPwBaru.Name = "tbPwBaru";
            tbPwBaru.Size = new Size(304, 43);
            tbPwBaru.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(tbPwLama);
            panel5.Location = new Point(35, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(372, 47);
            panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tbPwLama
            // 
            tbPwLama.Cursor = Cursors.IBeam;
            tbPwLama.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPwLama.Location = new Point(68, 2);
            tbPwLama.Name = "tbPwLama";
            tbPwLama.Size = new Size(304, 43);
            tbPwLama.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(14, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBack.TabIndex = 23;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // UbahPassword
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 235);
            ClientSize = new Size(576, 413);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 255, 235);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UbahPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UbahPassword";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblKonfirmasi;
        private Label lblPassBaru;
        private Label lblPassLama;
        private Button btnUbahPw;
        private Panel panel8;
        private PictureBox pictureBox9;
        private TextBox tbKonfirmasiPw;
        private Panel panel7;
        private PictureBox pictureBox8;
        private TextBox tbPwBaru;
        private Panel panel5;
        private TextBox tbPwLama;
        private PictureBox pictureBox1;
        private PictureBox btnBack;
        private CheckBox showConfirmPw;
    }
}