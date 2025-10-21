using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._2_FajriRiqzaMustofa_xpplg1
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Hallo, " + nama + "!");
            Console.WriteLine("Semangat beljar C# hari ini!");
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama anda: ");
            string namasiswa = Console.ReadLine();
            SapaNama(namasiswa); // Memanggil fungsi dengan argumen
        }
    }
}
