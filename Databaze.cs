using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nárovec___závěrečný_projekt
{
    internal class Databaze
    {
        private List<Pojistenec> pojistenci = new List<Pojistenec>();

        public void PridejPojistence(string jmeno, string prijmeni, int telefoniCislo, int vek)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefoniCislo, vek));
        }

        public List<Pojistenec> NajdiPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezene = new List<Pojistenec>();
            foreach (Pojistenec z in pojistenci)
            {
                if ((z.Jmeno == jmeno) && (z.Prijmeni == prijmeni))
                    nalezene.Add(z);
            }
            return nalezene;
        }

        public void VymazPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezeno = NajdiPojistence(jmeno, prijmeni);
            foreach (Pojistenec z in nalezeno)
                pojistenci.Remove(z);
        }

        public void VypisPojistence()
        {
            if (pojistenci.Count > 0)
                foreach (Pojistenec pojistenec in pojistenci)
                {
                    Console.WriteLine(pojistenec);
                }
            else
                Console.WriteLine("Není veden žádný pojištěnec.");
        }
    }
}
