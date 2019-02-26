using System;

namespace ZPO4._2
{
    public class ZgadnijJakiDzienTygodnia : Gra
    {
        public string Dzisiaj { get; set; }
        public string NazwaGracza { get; set; }

        protected override void UstawGre()
        {
            Dzisiaj = ((DzienTygodnia)((int)DateTime.Now.DayOfWeek)).ToString();
            Console.WriteLine("Jak się nazywasz?");
            NazwaGracza = Console.ReadLine();
            Console.WriteLine("Dobrze, zagrajmy w gre, " + NazwaGracza + ".");
        }

        protected override void RozegrajGre()
        {
            Console.WriteLine("Utknales nad meczacym Cie problemem i tak Cie wciagnal, ze nie jestes pewien ile czasu nad nim siedziales. Zgadnij jaki dzisiaj dzien tygodnia?");
            int i = 0;
            for (; i < 5; i++)
            {
                Console.WriteLine("Proba " + (i + 1) + " na 6.");
                string dzien = (Console.ReadLine()).ToLower();
                if (dzien == Dzisiaj)
                {
                    Console.WriteLine("Tak jest! Zgadles! Dzisiaj " + dzien + ".");
                    Zwyciezca = NazwaGracza;
                    i = 10;
                    break;
                }
                else
                {
                    Console.WriteLine("Nie, " + dzien + " to nie dzisiaj.");
                }
            }

            if (i != 10)
            {
                Console.WriteLine("Niezle nieogarniasz, idz sie lepiej wyspij.");
                Zwyciezca = "Komputer";
            }
        }
    }

    public enum DzienTygodnia
    {
        niedziela,
        poniedzialek,
        wtorek,
        sroda,
        czwartek,
        piatek,
        sobota
    }
}