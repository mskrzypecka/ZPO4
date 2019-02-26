using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4.Dane
{
    public class Folder : IDane
    {
        public string Nazwa { get; set; }
        private IList<IDane> dane;

        public Folder(string nazwa)
        {
            dane = new List<IDane>();
            Nazwa = nazwa;
        }

        public void OdczytajZawartosc()
        {
            Console.Write(Nazwa + ":");
            foreach (var dana in dane)
            {
                Console.WriteLine();
                if (dana.GetType().ToString().Contains("Folder"))
                {
                    Console.Write(Nazwa + " -> ");
                    dana.OdczytajZawartosc();
                }
                else
                    Console.Write("......... " + dana.DawajNazwe());
            }
        }

        public void DodajZawartosc(IDane dane) => this.dane.Add(dane);

        public void UsunZawartosc(IDane dane) => this.dane.Remove(dane);

        public double ObliczRozmiar() => dane.Where(x => x is Plik).Sum(x => x.ObliczRozmiar());

        public string DawajNazwe() => Nazwa;
    }
}
