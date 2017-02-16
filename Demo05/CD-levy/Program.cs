using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD-levy
{
    class Program
{
    static void Main(string[] args)
    {
        CD = new CD();
        CD.LevyNimi = "Imaginaerum";
        CD.Esittaja = "Nightwish";
        Console.WriteLine("Albumi: " + CD.LevyNimi);
        Console.WriteLine("Artisti: " + CD.Esittaja);
        Console.WriteLine("Sisaltaa muun muasssa kappaleet: ");

        Biisi biisi1 = new Biisi
        {
            BiisiNimi = "Taikatalvi",
            BiisiPituus = "2.35"
        };

        Biisi biisi2 = new Biisi
        {
            BiisiNimi = "Storytime",
            BiisiPituus = "5.31"
        };

        Biisi biisi3 = new Biisi
        {
            BiisiNimi = "Ghost River",
            BiisiPituus = "5.25"
        };

        Biisi biisi4 = new Biisi
        {
            BiisiNimi = "Slow, Love, Slow",
            BiisiPituus = "5.50"
        };

        Biisi biisi5 = new Biisi
        {
            BiisiNimi = "I Want My Tiers Back",
            BiisiPituus = "5.07"
        };

        //Kokoelma.AddBiisi(biisi1);
        //Kokoelma.AddBiisi(biisi2);
        //Kokoelma.AddBiisi(biisi3);
        //Kokoelma.AddBiisi(biisi4);
        //Kokoelma.AddBiisi(biisi5);

        //Kokoelma.PrintCollection();???

    }
}
}