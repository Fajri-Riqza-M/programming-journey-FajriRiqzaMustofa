using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan usia: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("Free tiket ");
            }
            else if (umur < 12)
            {
                Console.WriteLine("Harga tiket Rp10.000 ");
            }
            else if (umur < 60)
            {
                Console.WriteLine("Harga tiket Rp.30.000 ");
            }
            else
            {
                Console.WriteLine("Harga tiket Rp.20.000 (DISKON LANSIA) ");
            }
        }
    }
}
