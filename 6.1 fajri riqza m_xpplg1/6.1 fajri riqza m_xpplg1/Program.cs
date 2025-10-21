using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array dengan 5 elemen tipe data string
            string[] siswa = new string[5];

            // Mengisi elemen array
            siswa[0] = "Andi";
            siswa[1] = "Joko";
            siswa[2] = "Firman";
            siswa[3] = "furqon";
            siswa[4] = "jibril";

            //Menampilkan isi array perulangan
            Console.WriteLine("Daftar Nama Siswa;");
            Console.WriteLine("siswa ke-1: " + siswa[0]);
            Console.WriteLine("siswa ke-2: " + siswa[1]);
            Console.WriteLine("siswa ke-3: " + siswa[2]);
            Console.WriteLine("siswa ke-4: " + siswa[3]);
            Console.WriteLine("siswa ke-5: " + siswa[4]);

        }
    }
}
