using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Wybierz gre:\n1. Zgadnij Liczbe\n2. Zgadnij jaki dzien tygodnia\n1/2/exit?");
                string answer = Console.ReadLine();
                Gra gra = null;

                switch (answer)
                {
                    case "1":
                        gra = new ZgadnijLiczbe();
                        gra.Run();
                        break;
                    case "2":
                        gra = new ZgadnijJakiDzienTygodnia();
                        gra.Run();
                        break;
                    case "exit":
                        i = 10;
                        break;
                }
            }
        }
    }
}
