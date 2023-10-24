using System.Text;
namespace KoczkaBSolarSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> bolygok = new();
            using StreamReader sr = new(@"..\..\..\src\solsys.txt", Encoding.UTF8);
            while (!sr.EndOfStream) bolygok.Add(new Bolygo(sr.ReadLine()));
            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");
            var atlag = bolygok.Average(p=>p.HoldSzam);
            Console.WriteLine($"3.2: a naprendszerbena bolygóknak átlagosan {atlag} holdjuk van");
            var legnagyobb = bolygok.Max(p=>p.TerfogatFoldhoz);
            Console.WriteLine($"3.3: a legnagyobb térfogatú bolygó a {legnagyobb}");
            Console.Write("írd be a keresett bolygó nevét: ");
            string kertbolygo = Console.ReadLine();
            var kereses = bolygok.Where(p=>p.Nev.Contains(kertbolygo));
            if (kereses) Console.WriteLine("Van ilyen bolygó");
            else Console.WriteLine("Nincs ilyen bolygó");
            Console.Write("Írj be egy egész számot: ");
            int holdas = Convert.ToInt32(Console.ReadLine());
            var tobbhold = bolygok.Where(p=>p.HoldSzam>holdas).ToList();
            Console.WriteLine($"a következő bolygóknak van {holdas}-nal több holdja:\n{tobbhold}");

        }
        
        
    }
}