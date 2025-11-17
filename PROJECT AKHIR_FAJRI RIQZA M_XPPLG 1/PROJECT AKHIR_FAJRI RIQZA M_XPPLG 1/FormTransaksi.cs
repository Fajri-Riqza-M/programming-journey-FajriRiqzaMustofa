using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace PROJECT_AKHIR_FAJRI_RIQZA_M_XPPLG_1
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }
        private void btnPesanTiket_Click(object sender, EventArgs e)
        {
        }

        private void btnTampilkanDaftar_Click(object sender, EventArgs e)
        {
        }


        private void lblJudul_Load(object sender, EventArgs e)
        {

        }



        private void btnPesan_Click(object sender, EventArgs e)
        {
            // Validasi Nama
            if (txtNama.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Validasi Nama");
                return;
            }

            // Validasi Umur & Jumlah
            if (txtUmur.Text == "" || txtJumlahTiket.Text == "")
            {
                MessageBox.Show("Isi semua data!", "Validasi Umur & Jumlah Tiket");
                return;
            }

            // Validasi Umur Minimal
            int umur = int.Parse(txtUmur.Text);
            if (umur < 14)
            {
                MessageBox.Show($"❌ Maaf, umur minimal 14 tahun!\nUmur Anda : {umur} tahun", "Validasi Umur");
                return;
            }

            // Validasi Tinggi Badan Minimal
            int tinggi = (int)numTinggiBadan.Value;
            if (tinggi < 155)
            {
                MessageBox.Show($"❌ Maaf, tinggi minimal 155 cm!\nTinggi Anda: {tinggi} cm", "Validasi Tinggi Badan");
                return;
            }

            // Validasi CheckBox (harus pilih minimal 1)
            if (!chkAnak.Checked && !chkRemaja.Checked && !chkDewasa.Checked)
            {
                MessageBox.Show("Pilih minimal 1 kategori tiket!", "Kategori Tiket");
                return;
            }

            int jumlah = int.Parse(txtJumlahTiket.Text);
            int totalSemua = 0;
            string kategoriDipilih = "";
            int jumlahKategori = 0;

            // Hitung semua kategori yang dicentang
            if (chkAnak.Checked)
            {
                int hargaAnak = 50000 * jumlah;
                totalSemua += hargaAnak;
                kategoriDipilih += "Anak ";
                jumlahKategori++;
            }

            if (chkRemaja.Checked)
            {
                int hargaRemaja = 75000 * jumlah;
                totalSemua += hargaRemaja;
                kategoriDipilih += "Remaja ";
                jumlahKategori++;
            }
            if (chkDewasa.Checked)
            {
                int hargaDewasa = 100000 * jumlah;
                totalSemua += hargaDewasa;
                kategoriDipilih += "Dewasa ";
                jumlahKategori++;
            }

            int totalTiket = jumlah * jumlahKategori;
            int total = totalSemua;

            // Diskon 10% kalau total tiket 5+
            string diskonText = "";
            if (totalTiket >= 5)
            {
                total = total - (total * 10 / 100);
                diskonText = " (Diskon 10%)";
            }

            // Input Uang Bayar
            string inputBayar = Microsoft.VisualBasic.Interaction.InputBox($"Total Bayar: Rp {total:N0}{diskonText}\nMasukkan uang bayar:\n\n\n❌Ingat jangan utang yaa!!!", "Pembayaran", "");
            if (inputBayar == "") return;

            // Validasi uang bayar
            if (!int.TryParse(inputBayar, out int uangBayar))
            {
                MessageBox.Show("Nominal tidak valid!", "Pembayaran");
                return;
            }

            // Cek cukup atau tidak
            if (uangBayar < total)
            {
                MessageBox.Show($"❌ Nahkan Uangnya kurang!\nKurang: Rp {(total - uangBayar):N0}");
                return;
            }

            int kembalian = uangBayar - total;

            // Konfirmasi
            string pesan = $"Nama     : {txtNama.Text}\n";
            pesan += $"Umur     : {umur} tahun\n";
            pesan += $"Tinggi   : {tinggi} cm ✓\n";
            pesan += $"Kategori : {kategoriDipilih}\n";
            pesan += $"Jumlah   : {totalTiket} tiket ({jumlah} x {jumlahKategori} kategori)\n";
            pesan += $"Total    : Rp {total:N0}{diskonText}\n";
            pesan += $"Bayar    : Rp {uangBayar:N0}\n";
            pesan += $"Kembalian: Rp {kembalian:N0}\n\n";
            pesan += "Konfirmasi pemesanan?";

            if (MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                // Tambah ke list
                listPembeli.Items.Add($"{txtNama.Text} - {umur} th - {tinggi} cm - {kategoriDipilih} - {totalTiket} tiket - Rp {total:N0} - Rp {kembalian} ");

                MessageBox.Show($"✓ Pemesanan berhasil!\nDan jangan lupa kembali lagi yaaa😍😍😍  \nKembalian: Rp {kembalian:N0}", "Sukses");

                // Reset form
                txtNama.Clear();
                txtUmur.Clear();
                txtJumlahTiket.Clear();
                numTinggiBadan.Value = 120;
                chkAnak.Checked = false;
                chkRemaja.Checked = false;
                chkDewasa.Checked = false;
            }
        }

        private void cmbHarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTinggiBadan_ValueChanged(object sender, EventArgs e)
        {
            numTinggiBadan.Maximum = 200; // isi 200 cm

        }

        private void listPembeli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkanDaftar_Click_1(object sender, EventArgs e)
        {
            if (listPembeli.Items.Count == 0)
            {
                MessageBox.Show("Belum ada data pembeli");
                return;
            }

            string daftar = "═════════════════════════════════════════════════════════════════\n";
            daftar += "                    DAFTAR PEMBELI TIKET\n";
            daftar += "═════════════════════════════════════════════════════════════════\n\n";

            // FOR LOOP untuk tampilkan daftar
            for (int i = 0; i < listPembeli.Items.Count; i++)
            {
                daftar += $"{i + 1}. {listPembeli.Items[i]}\n";
            }

            daftar += $"\n═════════════════════════════════════════════════════════════════";
            daftar += $"\nTotal Pembeli: {listPembeli.Items.Count}";

            MessageBox.Show(daftar, "Rincian Pembeli");
        }

        private void chkAnak_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUmur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJumlahTiket_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvrincianpembeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void listpembeli_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDaftar_Click(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkRemaja_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
