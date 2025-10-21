using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_fajririqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umurmu: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur >= 18)
            {
                Console.WriteLine("Anda sudah cukup umur untuk membuat KTP. ");
            }
        }
    }
}
