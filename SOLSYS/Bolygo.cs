using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLSYS
{
    internal class Bolygo
    {
        public string Neve { get; set; }
        public int Holdak { get; set; }
        public double Terfogat { get; set; }

        public Bolygo(string sor)
        {
            var adat = sor.Split(';');
            Neve = adat[0];
            Holdak = int.Parse(adat[1]);
            Terfogat = double.Parse(adat[2].Replace('.', ','));
        }
    }
}
