using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_AKHIR_FAJRI_RIQZA_M_XPPLG_1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //username dan password yang benar
            string usernameTrue = "RIXXXZA";
            string passwordtrue = "Warbam12345";

            //Mengambil Input dari user
            string usernameInput = txtUsername.Text;
            string passwordInput = txtPassword.Text;

            //validasi Login
            if (usernameInput == usernameTrue && passwordInput == passwordtrue)
            {
                // jika login Berhasil
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Membuka Transaksi
                FormTransaksi formTransaksi = new FormTransaksi();
                formTransaksi.Show();

                // Menyembunyikan Form Login (bukan menutup, agar aplikasi tidak berhenti)
                this.Hide();
            }
            else
            {
                // Jika Login gagal
                MessageBox.Show("Username atau Password salah!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Membersihkan field password
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
