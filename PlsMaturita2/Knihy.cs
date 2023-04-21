using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlsMaturita2
{
    public class Knihy
    {
        public Knihy(int idKnihy, string nazev, string autor, DateTime datum)
        {
            IdKnihy = idKnihy;
            Nazev = nazev;
            Autor = autor;
            Datum = datum;
        }

        public int IdKnihy { get; set; }
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public DateTime Datum { get; set; }
    }
}
