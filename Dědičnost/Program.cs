using System;

namespace Test1
{
    class Osoba
    {
        public string Jmeno { get; set; }
        
    }
    // Do následujícího kódu doplňte definici třídy Zamestnanec a napište jaké jsou výhody a nevýhody dědičnosti kódu.
    // Vyhody: trida, ktera zdedi muze pristupovat ke vsem funkcim zdedene tridy, spolehlivost z hlediska opetovneho pouziti, jelikoz kod (zdedeny) je jiz odladen a funkcni
    //          dedicnost pomaha snizovani redundance kodu a snizuje spotrebu pameti
    //
    //Nevyhody: vazba mezi zakladni tridou a odvozenou, nespravne pouziti muze vest k jinemu reseni, nespravna zmena zakladni tridy primo ovlivni vsechny podrizene, zdedene
    //          zdedene funkce pracuji pomaleji nez normalni
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
