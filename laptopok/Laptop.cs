using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptopok
{
    public class Laptop
    {
        public int Azonosito { get; set; }
        public string Tipus { get; set; }
        public int Sebesseg { get; set; }
        public string OS { get; set; }
        public string Gyarto { get; set; }
        public string Modell { get; set; }
        public double AkkuIdeje /*ÓRA*/ { get; set; }
        public double Súly /*KG*/ { get; set; }
        public string[] VezetekNelkuli { get; set; }

        public Laptop(string s)
        {
            var v = s.Split('|');
            this.Azonosito = int.Parse(v[0]);
            var processzor = v[1].Split(" ");
            
        }
    }
}
