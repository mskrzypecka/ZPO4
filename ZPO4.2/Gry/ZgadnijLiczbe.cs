using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4._2
{
    public class ZgadnijLiczbe : Gra
    {
        public int WylosowanaLiczba { get; set; }
        public string NazwaGracza { get; set; }

        protected override void UstawGre()
        {
            WylosowanaLiczba = (new Random()).Next(50);
            Console.WriteLine("Jak się nazywasz?");
            NazwaGracza = Console.ReadLine();
            Console.WriteLine("Dobrze, zagrajmy w gre, " + NazwaGracza + ".");
        }

        protected override void RozegrajGre()
        {
            Console.WriteLine("O jakiej liczbie mysle [0-100]?");
            int i = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine("Proba " + (i + 1) + " na 5.");
                int liczba;
                Int32.TryParse(Console.ReadLine(), out liczba);

                if (liczba == WylosowanaLiczba)
                {
                    Zwyciezca = NazwaGracza;
                    i = 10;
                    break;
                }
                else if (liczba < WylosowanaLiczba)
                {
                    Console.WriteLine("Za malo.");
                }
                else
                {
                    Console.WriteLine("Za duzo.");
                }
            }

            if(i != 10)
            {
                Zwyciezca = "Komputer";
            }
        }        
    }
}
