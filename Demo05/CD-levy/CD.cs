using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD-levy
{
    class CD
{
    public string LevyNimi { get; set; }
    public string Esittaja { get; set; }

    private List<Biisi> biisit;

    public CD()
    {
        biisit = new List<Biisi>();
    }

    public void UusiBiisi(Biisi biisit)
    {
        biisit.Add(biisi);
    }


    public void PrintCollection()
    {
        foreach (Biisi biisi in biisit)
        {
            Console.WriteLine(biisi.ToString());
        }
    }
}
}