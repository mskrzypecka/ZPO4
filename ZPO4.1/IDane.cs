using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4
{
    public interface IDane
    {
        void OdczytajZawartosc();
        void DodajZawartosc(IDane dane);
        void UsunZawartosc(IDane dane);
        double ObliczRozmiar();
        string DawajNazwe();
    }
}
