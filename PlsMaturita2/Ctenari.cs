using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlsMaturita2
{
    public class Ctenari
    {
        public Ctenari(int idCtenar, string jmeno, string prijmeni, int pujcenychKnih)
        {
            IdCtenar = idCtenar;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            PujcenychKnih = pujcenychKnih;
        }

        public int IdCtenar { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int PujcenychKnih { get; set; }
        
    }
}
