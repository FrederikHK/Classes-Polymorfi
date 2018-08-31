using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDYR
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dyr = new List<string>();

            Dyr elefant = new Elefant("Vegetarisk", 1500.25);
            Dyr hund = new Hund("Hundefoder", 25.54);
            Dyr kat = new Kat("Kattemad", 5.45);
            dyr.Add(elefant.udskrivDyr());
            dyr.Add(hund.udskrivDyr());
            dyr.Add(kat.udskrivDyr());
            foreach (var animal in dyr)
            {
                Console.WriteLine(animal);
            }
            Console.ReadLine();
        }
    }
}
