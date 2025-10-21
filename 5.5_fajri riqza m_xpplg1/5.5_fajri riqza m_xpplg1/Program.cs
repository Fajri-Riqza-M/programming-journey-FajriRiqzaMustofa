using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. instalasi variabel  perhitungan (counter)
            int angka = 1;

            Console.WriteLine("menampilkan angka 1 sampai 20:");

            // 2. blok 'do-while'
            do
            {
                // tampilkan nilai variabl 'angka' saat ini
                Console.WriteLine(angka);

                // tampilkan nilai 'angka' sebanyak 1(increment)
                angka++;

                // uji kondisi: loop berlanjut selama 'angka' kurang dari atau sama dngan 
            } while (angka <= 20);

            Console.WriteLine("selesai.");
        }
    }
}
