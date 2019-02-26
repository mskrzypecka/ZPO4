using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO4._2
{
    public abstract class Gra
    {
        public string Zwyciezca { get; set; }

        protected abstract void UstawGre();
        protected abstract void RozegrajGre();
        protected void SkonczGre() => Console.WriteLine("Gra jest skonczona.");
        protected virtual void WyswietlZwyciezce() => Console.WriteLine("Wygranym zostal " + Zwyciezca);

        public void Run()
        {
            this.UstawGre();
            this.RozegrajGre();
            this.SkonczGre();
            this.WyswietlZwyciezce();
        }
    }
}
