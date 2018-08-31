using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDYR
{
    abstract class Dyr
    {
        public string art { get; set; }
        public string foder { get; set; }
        public string lyd { get; set; }
        public double vaegt { get; set; }

        public string udskrivDyr()
        {
            return "Art: " + art + " "+ "Foder: " + foder + " "+ "lyd: " + lyd + " "+ "Vægt: " + vaegt;
        }
    }

    class Elefant : Dyr
    {
        public Elefant(string f, double v)
        {
            this.vaegt = v;
            this.foder = f;
            this.lyd = "Trut";
            this.art = "African";
        }
    }

    class Hund : Dyr
    {
        public Hund(string f, double v)
        {
            this.vaegt = v;
            this.foder = f;
            this.lyd = "Vuf";
            this.art = "Lupin";
        }
    }

    class Kat : Dyr
    {
        public Kat(string f, double v)
        {
            this.vaegt = v;
            this.foder = f;
            this.lyd = "Miaw";
            this.art = "Felis catos";
        }
    }

    
}
