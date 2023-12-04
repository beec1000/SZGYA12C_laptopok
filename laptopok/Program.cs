using System.Linq;

namespace laptopok
{
    public class Program
    {
        static List<Laptop> F7(List<Laptop> l) 
        { 
            return l.Where(d => !d.OS.Contains("Windows") && d.Suly >= 2).ToList();
        }

        static List<Laptop> F8(List<Laptop> l) 
        { 
            var x = l.Min(d => d.AkkuIdeje);
            return l.Where(d => d.AkkuIdeje == x).ToList();
        }

        static double F9(List<Laptop> l) 
        { 
            return l.Average(d => double.Parse(d.Processzor.Split(" ").Last()));
        }

        static List<string> F10(List<Laptop> l)
        {
            var x = l.Where(d => d.VezetekNelkuli.Contains("Bluetooth 5.2"));
            var y = x.Select(d => d.GyartoModell.Split(" ").First()).Distinct().OrderBy(d => d).ToList();
            return y;
        }

        static List<Laptop> F11(List<Laptop> l)
        {
            var x = l.Where(d => d.Processzor.Contains("AMD") && d.Suly > 1.3).ToList();
            return x;
        }

        static void Main(string[] args)
        {
            var laptopok = new List<Laptop>();

            using var sr = new StreamReader(@"..\..\..\src\laptopok.txt");
            {
                _ = sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    laptopok.Add(new Laptop(sr.ReadLine()));
                }
            }

            foreach (var i in laptopok)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("7. feladat");
            var laptopokF7 = new List<Laptop>(laptopok);
            var f7 = F7(laptopokF7);
            Console.WriteLine($"{f7.Count}db olyan laptop van ami több mint 2kg és nem Windows van rajta.");

            Console.WriteLine("8. feladat");
            var f8 = F8(laptopok);
            foreach (var i in f8)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"{f8.Count}db ilyen laptop van, legkisebb akku idő: {f8.First().AkkuIdeje}");

            Console.WriteLine("9. feladat");
            var f9 = F9(laptopok);
            Console.WriteLine($"Az átlag processzor sebesség: {f9}");

            Console.WriteLine("10. feladat");
            var f10 = F10(laptopok);
            if (f10.Count != null)
            {
                foreach (var i in f10)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("HIBA! 404");
            }

            Console.WriteLine("11. feladat");
            var f11 = F11(laptopok);
            Console.WriteLine("1,3kg súlynál nehezebb AMD-s laptopok azonositói: ");
            if (f11 != null)
            {
                foreach (var i in f11)
                {
                    Console.WriteLine(i.Azonosito);
                }
            }
            else
            {
                Console.WriteLine("HIBA! 404");
            }

            //13. feladat
            using var sw = new StreamWriter(@"..\..\..\src\laptopok2.txt");
            {
                foreach (var i in laptopok)
                {
                    sw.WriteLine($"{i.Processzor}|{i.SulyG}");
                }
            }

        }
    }
}