﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_fajri_riqza_m_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hitungan = 5;
            Console.WriteLine("Memulai hitungan mundur :");
            while (hitungan > 0)
            {
                Console.WriteLine($"Hitungan : {hitungan}");
                hitungan = hitungan - 1;
            }
            Console.WriteLine("Selesai Hitungan mundur berakhir.");
        }
    }
}
