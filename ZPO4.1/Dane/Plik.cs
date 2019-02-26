using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4.Dane
{
    public class Plik : IDane
    {
        public string Nazwa { get; set; }
        public string Zawartosc { get; private set; }
        public double Rozmiar { get => Zawartosc.Length; private set => Rozmiar = value; }
        

        public Plik(string nazwa)
        {
            Nazwa = nazwa;
        }

        public void OdczytajZawartosc()
        {
            Console.WriteLine(Zawartosc);
        }

        public void DodajZawartosc(IDane dane) => Zawartosc += DawajNazwe();

        public void UsunZawartosc(IDane dane) => Zawartosc.Replace(dane.DawajNazwe(), "");

        public double ObliczRozmiar() => Rozmiar;

        public string DawajNazwe() => Nazwa;
    }
}
