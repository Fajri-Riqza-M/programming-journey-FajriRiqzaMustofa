using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan angkam: ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 0)
            {
                Console.WriteLine("Angkamu positif ");
            }
            else
            {
                Console.WriteLine("Angkamu negatif ");
            }
        }
    }
}
