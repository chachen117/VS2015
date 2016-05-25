using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Ch16_LINQ
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }

        public Comic(String Name, int Issue)
        {
            this.Name = Name;
            this.Issue = Issue;
        }

        private static List<Comic> BuildCatalog(){
            List<Comic> comics = new List<Comic>();

            comics.Add(new Comic("Johnny America vs. the Pinko", 6));
            comics.Add(new Comic("Rock and Roll (limited edition)", 19));
            comics.Add(new Comic("Woman's Work", 36));
            comics.Add(new Comic("Hippie Madness (misprinted)", 57));
            comics.Add(new Comic("Revenge of the New Wave Freak (damaged)", 68));
            comics.Add(new Comic("Black Monday", 74));
            comics.Add(new Comic("Tribal Tattoo Madness", 83));
            comics.Add(new Comic("The Death of an Object", 97));
            return comics;
        }

        private static Dictionary<int,int> GetPrices()
        {
            Dictionary<int, int> values = new Dictionary<int, int> ();
            values.Add(6, 3600);
            values.Add(19, 500);
            values.Add(36, 650);
            values.Add(57, 13525);
            values.Add(68, 250);
            values.Add(74, 75);
            values.Add(83, 25);
            values.Add(97, 35);
            return values;
        }

        //static void Main(string[] args)
        //{
        //    List<Comic> comics = BuildCatalog();
        //    Dictionary<int, int> values = GetPrices();

        //    var mostExpensive = from comic in comics
        //                        where values[comic.Issue] > 500
        //                        orderby values[comic.Issue] descending
        //                        select comic;

        //    foreach (Comic comic in mostExpensive)
        //        Console.WriteLine("{0} is worth {1:c}", comic.Name, values[comic.Issue]);

        //    Console.ReadLine();
        //}
    }
}
