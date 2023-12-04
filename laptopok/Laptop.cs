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
        public string Processzor { get; set; }
        public string OS { get; set; }
        public string GyartoModell { get; set; }
        public double AkkuIdeje /*ÓRA*/ { get; set; }
        public double Suly /*KG*/ { get; set; }
        public string[] VezetekNelkuli { get; set; }

        //12. feladat
        public double SulyG => Suly * 1000;


        public Laptop(string s)
        {
            var v = s.Split('|');
            this.Azonosito = int.Parse(v[0]);
            this.Processzor = v[1];
            this.OS = v[2];
            this.GyartoModell = v[3];
            this.AkkuIdeje = double.Parse(v[4]);
            this.Suly = double.Parse(v[5]);
            this.VezetekNelkuli = v[6].Split(", ");

        }

        public override string ToString()
        {
            return $"{this.Azonosito}|{this.Processzor}|{this.OS}|{string.Join(", ", this.GyartoModell)}|{this.AkkuIdeje}|{this.Suly}|{string.Join(", ", this.VezetekNelkuli)}";
        }
    }
}
