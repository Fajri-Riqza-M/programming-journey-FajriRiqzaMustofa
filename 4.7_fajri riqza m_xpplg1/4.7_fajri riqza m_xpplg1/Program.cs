using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._7_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai ujian: ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("Grade A ");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Grade B ");
            }
            else if (nilai >= 60)
            {
                Console.WriteLine("Grade C ");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
        }
    }
}
