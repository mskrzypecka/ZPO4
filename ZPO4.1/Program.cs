using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO4.Dane;

namespace ZPO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder C = new Folder("C");
            Folder ProgramFiles = new Folder("Program Files");
            C.DodajZawartosc(ProgramFiles);

            Folder Java = new Folder("Java");
            ProgramFiles.DodajZawartosc(Java);

            Plik ReadMe = new Plik("README.txt");
            Java.DodajZawartosc(ReadMe);
            Plik Welcome = new Plik("Welcome.html");
            Java.DodajZawartosc(Welcome);

            Folder bin = new Folder("bin");
            Java.DodajZawartosc(bin);

            Plik JavaJar = new Plik("java.jar");
            bin.DodajZawartosc(JavaJar);
            Plik JavawJar = new Plik("javaw.jar");
            bin.DodajZawartosc(JavawJar);

            Folder Microsoft = new Folder("Microsoft");
            ProgramFiles.DodajZawartosc(Microsoft);

            Plik Eula = new Plik("eula.docx");
            Microsoft.DodajZawartosc(Eula);
            Plik ReadMeHtml = new Plik("readme.html");
            Microsoft.DodajZawartosc(ReadMeHtml);
            Plik ThirdParty = new Plik("thirdpartynotices.docx");
            Microsoft.DodajZawartosc(ThirdParty);

            C.OdczytajZawartosc();

            Console.ReadKey();
        }
    }
}
