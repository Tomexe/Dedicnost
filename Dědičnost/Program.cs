using System;

namespace Test1
{
    class Osoba
    {
        public string Jmeno { get; set; }
        
    }
    // Do následujícího kódu doplňte definici třídy Zamestnanec a napište jaké jsou výhody a nevýhody dědičnosti kódu.

    class Zamestnanec : Osoba
    {
        public double Mzda { get; set; }

        public Zamestnanec(string jmeno, double mzda)
        {
            Jmeno = jmeno;
            Mzda = mzda;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Jirina";
            double mzda = 35000;
            Zamestnanec zamestnanec = new Zamestnanec(jmeno, mzda);
            Console.WriteLine($"Zamestnanec jmeno: {zamestnanec.Jmeno} mzda: {zamestnanec.Mzda}");
        }
    }
}