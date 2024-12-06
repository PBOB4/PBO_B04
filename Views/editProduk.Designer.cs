namespace TeaSMart_App.Views
{
    partial class editProduk
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
            btnSubmit = new Button();
            btnAddImage = new Button();
            panel1 = new Panel();
            tbFileName = new TextBox();
            label6 = new Label();
            tbStok = new TextBox();
            cbJenis = new ComboBox();
            tbNama = new TextBox();
            label1 = new Label();
            dtPDiperbarui = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            tbHarga = new TextBox();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.FromArgb(8, 51, 0);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(217, 477);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 35);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnAddImage
            // 
            btnAddImage.AutoSize = true;
            btnAddImage.BackColor = Color.FromArgb(8, 51, 0);
            btnAddImage.FlatStyle = FlatStyle.Flat;
            btnAddImage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddImage.ForeColor = Color.White;
            btnAddImage.Location = new Point(207, 167);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(106, 35);
            btnAddImage.TabIndex = 19;
            btnAddImage.Text = "Edit Image";
            btnAddImage.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(54, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 235);
            panel1.TabIndex = 18;
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
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(136, 13);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(244, 30);
            tbNama.TabIndex = 2;
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
            // dtPDiperbarui
            // 
            dtPDiperbarui.Location = new Point(136, 160);
            dtPDiperbarui.Name = "dtPDiperbarui";
            dtPDiperbarui.Size = new Size(250, 27);
            dtPDiperbarui.TabIndex = 12;
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
            // tbHarga
            // 
            tbHarga.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(136, 49);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(244, 30);
            tbHarga.TabIndex = 4;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(203, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 119);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // editProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 199, 156);
            ClientSize = new Size(525, 546);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddImage);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "editProduk";
            Text = "editProduk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnAddImage;
        private Panel panel1;
        private TextBox tbFileName;
        private Label label6;
        private TextBox tbStok;
        private ComboBox cbJenis;
        private TextBox tbNama;
        private Label label1;
        private DateTimePicker dtPDiperbarui;
        private Label label2;
        private Label label4;
        private TextBox tbHarga;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox1;
    }
}