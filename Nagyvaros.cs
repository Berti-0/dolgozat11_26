using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat11_26
{
    internal class Nagyvaros
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public float Population { get; set; }

        public Nagyvaros(string adat)
        {
            string[] c = adat.Split(';');
            CityName = c[0];
            CountryName = c[1];
            Population = float.Parse(c[2]);
        }

        public override string ToString()
        {
            return $"Város neve:{CityName}\n" +
                $"Ország neve:{CountryName}\n" +
                $"{Math.Round(Population,2)}";
        }
    }

}
