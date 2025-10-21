using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array integer dengan 5 elemen
            int[] angka = new int[5];

            // Imput elemen array dari keyboard
            Console.Write("Masuka angka ke-1:  ");
            angka[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masuka angka ke-2:  ");
            angka[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masuka angka ke-3:  ");
            angka[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masuka angka ke-4:  ");
            angka[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masuka angka ke-5:  ");
            angka[4] = Convert.ToInt32(Console.ReadLine());

            // Menampilkan isi array tanpa perulangan
            Console.WriteLine("\nData yang anda masukan: ");
            Console.WriteLine("Nilai ke-1 :" + angka[0]);
            Console.WriteLine("Nilai ke-2 :" + angka[1]);
            Console.WriteLine("Nilai ke-3 :" + angka[2]);
            Console.WriteLine("Nilai ke-4 :" + angka[3]);
            Console.WriteLine("Nilai ke-5 :" + angka[4]);
        }
    }
}
