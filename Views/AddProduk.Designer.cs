namespace TeaSMart_App.Views
{
    partial class AddProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduk));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbNama = new TextBox();
            tbHarga = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtPDiperbarui = new DateTimePicker();
            panel1 = new Panel();
            tbFileName = new TextBox();
            label6 = new Label();
            tbStok = new TextBox();
            cbJenis = new ComboBox();
            btnAddImage = new Button();
            btnSubmit = new Button();
            btnBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(198, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(136, 13);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(244, 30);
            tbNama.TabIndex = 2;
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(136, 49);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(244, 30);
            tbHarga.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 52);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 3;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 88);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 5;
            label3.Text = "Jenis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 196);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 11;
            label4.Text = "File name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 160);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 9;
            label5.Text = "Diperbarui";
            // 
            // dtPDiperbarui
            // 
            dtPDiperbarui.Location = new Point(136, 160);
            dtPDiperbarui.Name = "dtPDiperbarui";
            dtPDiperbarui.Size = new Size(250, 27);
            dtPDiperbarui.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(tbFileName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbStok);
            panel1.Controls.Add(cbJenis);
            panel1.Controls.Add(tbNama);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtPDiperbarui);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbHarga);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(49, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 235);
            panel1.TabIndex = 14;
            // 
            // tbFileName
            // 
            tbFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFileName.Location = new Point(136, 196);
            tbFileName.Name = "tbFileName";
            tbFileName.Size = new Size(244, 30);
            tbFileName.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 128);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 16;
            label6.Text = "Stok";
            // 
            // tbStok
            // 
            tbStok.Location = new Point(139, 127);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(76, 27);
            tbStok.TabIndex = 15;
            // 
            // cbJenis
            // 
            cbJenis.FormattingEnabled = true;
            cbJenis.Items.AddRange(new object[] { "Ekonomis", "Premium", "Limited-Edition" });
            cbJenis.Location = new Point(136, 88);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(244, 28);
            cbJenis.TabIndex = 14;
            // 
            // btnAddImage
            // 
            btnAddImage.AutoSize = true;
            btnAddImage.BackColor = Color.FromArgb(8, 51, 0);
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(202, 154);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(106, 35);
            btnAddImage.TabIndex = 15;
            btnAddImage.Text = "Add Image";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.FromArgb(8, 51, 0);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(212, 464);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 35);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(10, 10);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(36, 36);
            btnBack.SizeMode = PictureBoxSizeMode.AutoSize;
            btnBack.TabIndex = 17;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 199, 156);
            ClientSize = new Size(525, 546);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddImage);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AddProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MelihatDetProduk";
            Load += AddProduk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbNama;
        private TextBox tbHarga;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtPDiperbarui;
        private Panel panel1;
        private Button btnAddImage;
        private Button btnSubmit;
        private ComboBox cbJenis;
        private Label label6;
        private TextBox tbStok;
        private TextBox tbFileName;
        private PictureBox btnBack;
    }
}