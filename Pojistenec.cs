using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Nárovec___závěrečný_projekt
{
    internal class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelefonniCislo { get; set; }
        public int Vek { get; set; }

        public Pojistenec(string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }

        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + TelefonniCislo + "\t" + Vek;
        }
    }
}
