using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD-levy
{
    class Biisi
{
    public string BiisiNimi { get; set; }
    public string BiisiPituus { get; set; }

    public override string ToString()
    {
        return BiisiNimi + " " + BiisiPituus;
    }


}
}