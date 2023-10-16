using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA23101208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Keres> keresek = new List<Keres>();
            using (StreamReader olvaso = new StreamReader(@"..\..\src\NASAlog.txt"))
            {
                while (!olvaso.EndOfStream)
                {
                    keresek.Add(new Keres(olvaso.ReadLine()));
                }
            }

            Console.WriteLine($"5. feladat: Kérések száma: {keresek.Count}");

            Console.ReadKey();
        }
    }
}
