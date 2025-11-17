namespace PROJECT_AKHIR_FAJRI_RIQZA_M_XPPLG_1
{
    partial class FormTransaksi
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
            lblJudul = new Label();
            lblNama = new Label();
            txtNama = new TextBox();
            lblUmur = new Label();
            txtUmur = new TextBox();
            lblJumlah = new Label();
            txtJumlahTiket = new TextBox();
            btnPesan = new Button();
            lblDaftar = new Label();
            lblTinggiBadan = new Label();
            lblHarga = new Label();
            numTinggiBadan = new NumericUpDown();
            btnTampilkanDaftar = new Button();
            lblTotal = new Label();
            label1 = new Label();
            lblAnak = new Label();
            lblremaja = new Label();
            lblDewasa = new Label();
            GbKetentuanharga = new GroupBox();
            label2 = new Label();
            listPembeli = new ListBox();
            chkAnak = new CheckBox();
            chkRemaja = new CheckBox();
            chkDewasa = new CheckBox();
            btnkeluar = new Button();
            ((System.ComponentModel.ISupportInitialize)numTinggiBadan).BeginInit();
            GbKetentuanharga.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(480, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(629, 46);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "PEMBELIAN TIKET ROLLER COASTER";
            lblJudul.Click += lblJudul_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.White;
            lblNama.Location = new Point(26, 76);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(143, 23);
            lblNama.TabIndex = 1;
            lblNama.Text = "Masukan Nama :";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.White;
            txtNama.Location = new Point(194, 72);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(176, 27);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // lblUmur
            // 
            lblUmur.AutoSize = true;
            lblUmur.BackColor = Color.Transparent;
            lblUmur.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUmur.ForeColor = Color.White;
            lblUmur.Location = new Point(29, 118);
            lblUmur.Name = "lblUmur";
            lblUmur.Size = new Size(140, 23);
            lblUmur.TabIndex = 3;
            lblUmur.Text = "Umur                :";
            // 
            // txtUmur
            // 
            txtUmur.BackColor = Color.White;
            txtUmur.Location = new Point(196, 117);
            txtUmur.Name = "txtUmur";
            txtUmur.Size = new Size(50, 27);
            txtUmur.TabIndex = 4;
            txtUmur.TextChanged += txtUmur_TextChanged;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.BackColor = Color.Transparent;
            lblJumlah.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlah.ForeColor = Color.White;
            lblJumlah.Location = new Point(29, 182);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(139, 23);
            lblJumlah.TabIndex = 5;
            lblJumlah.Text = "Jumlah Tiket    :";
            // 
            // txtJumlahTiket
            // 
            txtJumlahTiket.BackColor = Color.White;
            txtJumlahTiket.Location = new Point(196, 181);
            txtJumlahTiket.Name = "txtJumlahTiket";
            txtJumlahTiket.Size = new Size(50, 27);
            txtJumlahTiket.TabIndex = 6;
            txtJumlahTiket.TextChanged += txtJumlahTiket_TextChanged;
            // 
            // btnPesan
            // 
            btnPesan.BackColor = Color.Lime;
            btnPesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesan.ForeColor = Color.Black;
            btnPesan.Location = new Point(46, 295);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(94, 29);
            btnPesan.TabIndex = 7;
            btnPesan.Text = "Pesan Tiket";
            btnPesan.UseVisualStyleBackColor = false;
            btnPesan.Click += btnPesan_Click;
            // 
            // lblDaftar
            // 
            lblDaftar.AutoSize = true;
            lblDaftar.BackColor = Color.Transparent;
            lblDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaftar.ForeColor = Color.White;
            lblDaftar.Location = new Point(46, 327);
            lblDaftar.Name = "lblDaftar";
            lblDaftar.Size = new Size(122, 20);
            lblDaftar.TabIndex = 9;
            lblDaftar.Text = "Daftar Pembeli :";
            lblDaftar.Click += lblDaftar_Click;
            // 
            // lblTinggiBadan
            // 
            lblTinggiBadan.AutoSize = true;
            lblTinggiBadan.BackColor = Color.Transparent;
            lblTinggiBadan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTinggiBadan.ForeColor = Color.White;
            lblTinggiBadan.Location = new Point(26, 152);
            lblTinggiBadan.Name = "lblTinggiBadan";
            lblTinggiBadan.Size = new Size(142, 23);
            lblTinggiBadan.TabIndex = 11;
            lblTinggiBadan.Text = "Tinggi Badan    :";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.White;
            lblHarga.Location = new Point(29, 220);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(135, 23);
            lblHarga.TabIndex = 13;
            lblHarga.Text = "Kategori Tiket :";
            // 
            // numTinggiBadan
            // 
            numTinggiBadan.BackColor = Color.White;
            numTinggiBadan.Location = new Point(196, 148);
            numTinggiBadan.Name = "numTinggiBadan";
            numTinggiBadan.Size = new Size(150, 27);
            numTinggiBadan.TabIndex = 15;
            numTinggiBadan.ValueChanged += numTinggiBadan_ValueChanged;
            // 
            // btnTampilkanDaftar
            // 
            btnTampilkanDaftar.BackColor = Color.Lime;
            btnTampilkanDaftar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTampilkanDaftar.Location = new Point(146, 295);
            btnTampilkanDaftar.Name = "btnTampilkanDaftar";
            btnTampilkanDaftar.Size = new Size(151, 29);
            btnTampilkanDaftar.TabIndex = 20;
            btnTampilkanDaftar.Text = "Tampilkan Daftar";
            btnTampilkanDaftar.UseVisualStyleBackColor = false;
            btnTampilkanDaftar.Click += btnTampilkanDaftar_Click_1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(760, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 31);
            label1.TabIndex = 24;
            label1.Text = "Ketentuan Harga Tiket";
            // 
            // lblAnak
            // 
            lblAnak.AutoSize = true;
            lblAnak.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnak.Location = new Point(6, 46);
            lblAnak.Name = "lblAnak";
            lblAnak.Size = new Size(190, 23);
            lblAnak.TabIndex = 25;
            lblAnak.Text = "Anak - Anak : Rp 50.000";
            // 
            // lblremaja
            // 
            lblremaja.AutoSize = true;
            lblremaja.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblremaja.Location = new Point(6, 86);
            lblremaja.Name = "lblremaja";
            lblremaja.Size = new Size(153, 23);
            lblremaja.TabIndex = 26;
            lblremaja.Text = "Remaja : Rp 75.000";
            // 
            // lblDewasa
            // 
            lblDewasa.AutoSize = true;
            lblDewasa.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDewasa.Location = new Point(6, 129);
            lblDewasa.Name = "lblDewasa";
            lblDewasa.Size = new Size(165, 23);
            lblDewasa.TabIndex = 27;
            lblDewasa.Text = "Dewasa : Rp 100.000";
            // 
            // GbKetentuanharga
            // 
            GbKetentuanharga.BackColor = Color.White;
            GbKetentuanharga.Controls.Add(label2);
            GbKetentuanharga.Controls.Add(label1);
            GbKetentuanharga.Controls.Add(lblremaja);
            GbKetentuanharga.Controls.Add(lblDewasa);
            GbKetentuanharga.Controls.Add(lblAnak);
            GbKetentuanharga.Location = new Point(600, 295);
            GbKetentuanharga.Name = "GbKetentuanharga";
            GbKetentuanharga.Size = new Size(250, 201);
            GbKetentuanharga.TabIndex = 28;
            GbKetentuanharga.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 170);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 29;
            label2.Text = "JANGAN LUPA DIBELI YAAA";
            // 
            // listPembeli
            // 
            listPembeli.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPembeli.FormattingEnabled = true;
            listPembeli.Location = new Point(46, 352);
            listPembeli.Name = "listPembeli";
            listPembeli.Size = new Size(548, 144);
            listPembeli.TabIndex = 29;
            listPembeli.SelectedIndexChanged += listpembeli_SelectedIndexChanged_1;
            // 
            // chkAnak
            // 
            chkAnak.AutoSize = true;
            chkAnak.BackColor = Color.Transparent;
            chkAnak.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAnak.ForeColor = Color.Black;
            chkAnak.Location = new Point(187, 221);
            chkAnak.Name = "chkAnak";
            chkAnak.Size = new Size(159, 24);
            chkAnak.TabIndex = 30;
            chkAnak.Text = "Anak 3 - 12 Tahun";
            chkAnak.UseVisualStyleBackColor = false;
            // 
            // chkRemaja
            // 
            chkRemaja.AutoSize = true;
            chkRemaja.BackColor = Color.Transparent;
            chkRemaja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRemaja.Location = new Point(187, 251);
            chkRemaja.Name = "chkRemaja";
            chkRemaja.Size = new Size(184, 24);
            chkRemaja.TabIndex = 31;
            chkRemaja.Text = "Remaja 14 - 21 Tahun";
            chkRemaja.UseVisualStyleBackColor = false;
            chkRemaja.CheckedChanged += chkRemaja_CheckedChanged;
            // 
            // chkDewasa
            // 
            chkDewasa.AutoSize = true;
            chkDewasa.BackColor = Color.Transparent;
            chkDewasa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDewasa.Location = new Point(377, 251);
            chkDewasa.Name = "chkDewasa";
            chkDewasa.Size = new Size(139, 24);
            chkDewasa.TabIndex = 32;
            chkDewasa.Text = "Dewasa 22 - 50";
            chkDewasa.UseVisualStyleBackColor = false;
            // 
            // btnkeluar
            // 
            btnkeluar.BackColor = Color.Red;
            btnkeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkeluar.Location = new Point(303, 295);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(94, 29);
            btnkeluar.TabIndex = 33;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = false;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.istockphoto_1137975327_1024x1024;
            ClientSize = new Size(1571, 508);
            Controls.Add(btnkeluar);
            Controls.Add(chkDewasa);
            Controls.Add(chkRemaja);
            Controls.Add(chkAnak);
            Controls.Add(listPembeli);
            Controls.Add(GbKetentuanharga);
            Controls.Add(lblTotal);
            Controls.Add(btnTampilkanDaftar);
            Controls.Add(numTinggiBadan);
            Controls.Add(lblHarga);
            Controls.Add(lblTinggiBadan);
            Controls.Add(lblDaftar);
            Controls.Add(btnPesan);
            Controls.Add(txtJumlahTiket);
            Controls.Add(lblJumlah);
            Controls.Add(txtUmur);
            Controls.Add(lblUmur);
            Controls.Add(txtNama);
            Controls.Add(lblNama);
            Controls.Add(lblJudul);
            Name = "FormTransaksi";
            Text = "Form Transaksi";
            Load += lblJudul_Load;
            ((System.ComponentModel.ISupportInitialize)numTinggiBadan).EndInit();
            GbKetentuanharga.ResumeLayout(false);
            GbKetentuanharga.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblNama;
        private TextBox txtNama;
        private Label lblUmur;
        private TextBox txtUmur;
        private Label lblJumlah;
        private TextBox txtJumlahTiket;
        private Button btnPesan;
        private Label lblDaftar;
        private Label lblTinggiBadan;
        private Label lblHarga;
        private NumericUpDown numTinggiBadan;
        private Button btnTampilkanDaftar;
        private Button btnHitung;
        private ListBox HitungHargaTiket;
        private Label lblTotal;
        private Label label1;
        private Label lblAnak;
        private Label lblremaja;
        private Label lblDewasa;
        private GroupBox GbKetentuanharga;
        private Label label2;
        private ListBox listPembeli;
        private CheckBox chkAnak;
        private CheckBox chkRemaja;
        private CheckBox chkDewasa;
        private Button btnkeluar;
    }
}
