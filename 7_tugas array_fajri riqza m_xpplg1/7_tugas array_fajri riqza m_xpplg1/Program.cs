using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_tugas_array_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jumlah siswa
            int jumlahSiswa = 3;

            // Deklarasi array
            string[] nama = new string[jumlahSiswa];
            char[] jenisKelamin = new char[jumlahSiswa];
            string[] kelas = new string[jumlahSiswa];

            // Input data siswa
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.Write($"Masukkan nama siswa ke-{i + 1}: ");
                nama[i] = Console.ReadLine();

                Console.Write("Masukkan jenis kelamin (L/P): ");
                jenisKelamin[i] = Convert.ToChar(Console.ReadLine());

                Console.Write("Masukkan kelas: ");
                kelas[i] = Console.ReadLine();

                Console.WriteLine();
            }

            // Output data siswa
            Console.WriteLine("=== Data Siswa ===");
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.WriteLine($"Nama: {nama[i]} | JK: {jenisKelamin[i]} | Kelas: {kelas[i]}");
            }
        }
    }
}
