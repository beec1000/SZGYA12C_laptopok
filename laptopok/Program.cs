namespace laptopok
{
    public class Program
    {
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

        }
    }
}