namespace TeaSMart_App.Views
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            lblTotalHarga = new Label();
            label3 = new Label();
            lblKembali = new Label();
            btnSelesai = new Button();
            flyProduk = new FlowLayoutPanel();
            panel1 = new Panel();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lblNamaAdm = new Label();
            lblUsnAdm = new Label();
            lblIdAdm = new Label();
            lblTgltransaksi = new Label();
            lblIdTransaksi = new Label();
            label16 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            btnBack = new PictureBox();
            tbBayar = new TextBox();
            flyProduk.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(32, 502);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(472, 23);
            lblTotalHarga.TabIndex = 1;
            lblTotalHarga.Text = "Total Harga     :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 527);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 2;
            label3.Text = "Bayar              :";
            // 
            // lblKembali
            // 
            lblKembali.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembali.Location = new Point(32, 558);
            lblKembali.Name = "lblKembali";
            lblKembali.Size = new Size(472, 23);
            lblKembali.TabIndex = 3;
            lblKembali.Text = "Kembali          :";
            // 
            // btnSelesai
            // 
            btnSelesai.BackgroundImage = (Image)resources.GetObject("btnSelesai.BackgroundImage");
            btnSelesai.BackgroundImageLayout = ImageLayout.Zoom;
            btnSelesai.Cursor = Cursors.Hand;
            btnSelesai.FlatStyle = FlatStyle.Flat;
            btnSelesai.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelesai.ForeColor = Color.Green;
            btnSelesai.Location = new Point(204, 641);
            btnSelesai.Name = "btnSelesai";
            btnSelesai.Size = new Size(136, 48);
            btnSelesai.TabIndex = 4;
            btnSelesai.Text = "  ";
            btnSelesai.UseVisualStyleBackColor = true;
            btnSelesai.Click += btnSelesai_Click;
            // 
            // flyProduk
            // 
            flyProduk.AutoScroll = true;
            flyProduk.AutoSize = true;
            flyProduk.Controls.Add(panel1);
            flyProduk.FlowDirection = FlowDirection.TopDown;
            flyProduk.Location = new Point(32, 299);
            flyProduk.Name = "flyProduk";
            flyProduk.Size = new Size(490, 200);
            flyProduk.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 49);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(194, 14);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 3;
            label5.Text = "Rp100.000,00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(377, 14);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 2;
            label8.Text = "Rp100.000,00";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(326, 14);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 1;
            label7.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 14);
            label6.MaximumSize = new Size(143, 20);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 0;
            label6.Text = "Teh Hijau Ekonomis";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(188, 715);
            label9.Name = "label9";
            label9.Size = new Size(190, 24);
            label9.TabIndex = 9;
            label9.Text = "TERIMA KASIH ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(57, 172);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 15;
            label10.Text = "ADMIN:";
            // 
            // lblNamaAdm
            // 
            lblNamaAdm.AutoSize = true;
            lblNamaAdm.Location = new Point(57, 195);
            lblNamaAdm.Name = "lblNamaAdm";
            lblNamaAdm.Size = new Size(109, 20);
            lblNamaAdm.TabIndex = 16;
            lblNamaAdm.Text = "Najwa Maulida";
            // 
            // lblUsnAdm
            // 
            lblUsnAdm.AutoSize = true;
            lblUsnAdm.Location = new Point(57, 215);
            lblUsnAdm.Name = "lblUsnAdm";
            lblUsnAdm.Size = new Size(87, 20);
            lblUsnAdm.TabIndex = 17;
            lblUsnAdm.Text = "@username";
            // 
            // lblIdAdm
            // 
            lblIdAdm.AutoSize = true;
            lblIdAdm.Location = new Point(57, 235);
            lblIdAdm.Name = "lblIdAdm";
            lblIdAdm.Size = new Size(17, 20);
            lblIdAdm.TabIndex = 18;
            lblIdAdm.Text = "3";
            // 
            // lblTgltransaksi
            // 
            lblTgltransaksi.Location = new Point(316, 235);
            lblTgltransaksi.Name = "lblTgltransaksi";
            lblTgltransaksi.Size = new Size(180, 20);
            lblTgltransaksi.TabIndex = 21;
            lblTgltransaksi.Text = "23/12/2024";
            lblTgltransaksi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdTransaksi
            // 
            lblIdTransaksi.Location = new Point(386, 202);
            lblIdTransaksi.Name = "lblIdTransaksi";
            lblIdTransaksi.Size = new Size(109, 20);
            lblIdTransaksi.TabIndex = 20;
            lblIdTransaksi.Text = "#34";
            lblIdTransaksi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(365, 172);
            label16.Name = "label16";
            label16.Size = new Size(131, 23);
            label16.TabIndex = 19;
            label16.Text = "NO. FAKTUR:";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label19);
            panel2.Location = new Point(35, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 26);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Harga";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(429, 0);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 2;
            label17.Text = "Total";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(319, 0);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 1;
            label18.Text = "QTY";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(4, 0);
            label19.Name = "label19";
            label19.Size = new Size(59, 20);
            label19.TabIndex = 0;
            label19.Text = "Produk";
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBack.TabIndex = 22;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // tbBayar
            // 
            tbBayar.Cursor = Cursors.IBeam;
            tbBayar.Location = new Point(174, 528);
            tbBayar.Name = "tbBayar";
            tbBayar.Size = new Size(125, 27);
            tbBayar.TabIndex = 23;
            tbBayar.TextChanged += tbBayar_TextChanged;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 255, 235);
            ClientSize = new Size(553, 757);
            Controls.Add(lblKembali);
            Controls.Add(tbBayar);
            Controls.Add(lblTotalHarga);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(lblTgltransaksi);
            Controls.Add(lblIdTransaksi);
            Controls.Add(label16);
            Controls.Add(lblIdAdm);
            Controls.Add(lblUsnAdm);
            Controls.Add(lblNamaAdm);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(flyProduk);
            Controls.Add(btnSelesai);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembayaran";
            flyProduk.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotalHarga;
        private Label label3;
        private Label lblKembali;
        private Button btnSelesai;
        private FlowLayoutPanel flyProduk;
        private Panel panel1;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label10;
        private Label lblNamaAdm;
        private Label lblUsnAdm;
        private Label lblIdAdm;
        private Label lblTgltransaksi;
        private Label lblIdTransaksi;
        private Label label16;
        private Panel panel2;
        private Label label1;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label5;
        private PictureBox btnBack;
        private TextBox tbBayar;
    }
}