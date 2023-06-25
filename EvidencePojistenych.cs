using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nárovec___závěrečný_projekt
{
    internal class EvidencePojistenych
    {
        private Databaze databaze;

        public EvidencePojistenych()
        {
            databaze = new Databaze();
        }

        public void VypisPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> pojistenci = databaze.NajdiPojistence(jmeno, prijmeni);
            foreach (Pojistenec z in pojistenci)
                Console.WriteLine(z);
        }

        private string ZjistiJmeno()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            // while (!Console.ReadLine(), out jmeno)
                // Console.WriteLine("Chybné zadání, zadejte jméno znovu: ");
            return jmeno;
        }

        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            // while (!Console.ReadLine(), out jmeno)
            // Console.WriteLine("Chybné zadání, zadejte příjmení znovu: ");
            return prijmeni;
        }

        public void PridejPojistence()
        {
            string jmeno = ZjistiJmeno();
            
            string prijmeni = ZjistiPrijmeni();
            
            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            int telefonniCislo;
            while (!int.TryParse(Console.ReadLine(), out telefonniCislo))
            {
                Console.WriteLine("Zadejte telefonní číslo znovu:");
            }
            Console.WriteLine("Zadejte věk pojištěného:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Zadejte věk znovu:");
            }
            databaze.PridejPojistence(jmeno, prijmeni, telefonniCislo, vek);
        }

        public void VyhledejPojistence()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            List<Pojistenec> pojistenci = databaze.NajdiPojistence(jmeno, prijmeni);
            if (pojistenci.Count() > 0)
            {
                Console.WriteLine("Nalezeni tito pojištenci: ");
                foreach (Pojistenec z in pojistenci)
                    Console.WriteLine(z);
            }
            else
                Console.WriteLine("Nebyl nalezen žádný pojištěnec.");
        }

        public void VymazPojistence()
        {
            Console.WriteLine("Budou vymazáni pojištěnci podle jména a příjmení");
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            databaze.VymazPojistence(jmeno, prijmeni);
        }

        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("Dnes je: {0}", DateTime.Now);
            Console.WriteLine();
        }

        public void Vypis()
        {
            databaze.VypisPojistence();
        }
    }
}
