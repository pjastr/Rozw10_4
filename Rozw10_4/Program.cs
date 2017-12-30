using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, string> historia = new Dictionary<DateTime, string>();
            historia.Add(new DateTime(1410, 7, 15), "Bitwa pod Grunwaldem");
            historia.Add(new DateTime(1683, 9, 12), "Bitwa pod Wiedniem");
            historia.Add(new DateTime(972, 6, 24), "Bitwa pod Cedynia");
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("Stulecie {0}00-{0}99", i);
                foreach (var element in historia)
                {
                    if (element.Key.Year >= i * 100 && element.Key.Year <= i * 100 + 99)
                        Console.WriteLine("[ {0}, {1} ]", element.Key.ToString("dd.MM.yyy"), element.Value);
                }
            }
            Console.WriteLine("Po zmianie klucza");
            Dictionary<string, DateTime> historia2 = new Dictionary<string, DateTime>();
            foreach(var element in historia)
            {
                historia2.Add(element.Value, element.Key);
            }
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("Stulecie {0}00-{0}99", i);
                foreach (var element in historia2)
                {
                    if (element.Value.Year >= i * 100 && element.Value.Year <= i * 100 + 99)
                        Console.WriteLine("[ {0}, {1} ]", element.Value.ToString("dd.MM.yyy"), element.Key);
                }
            }
            Console.ReadKey();
        }
    }
}
