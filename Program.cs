using Nárovec___závěrečný_projekt;
using System.Diagnostics.Tracing;

internal class Program
{
    private static void Main(string[] args)
    {
        EvidencePojistenych evidencePojistenych = new EvidencePojistenych();
        char volba = '0';

        while (volba != 5)
        {
            evidencePojistenych.VypisUvodniObrazovku();
            Console.WriteLine();
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Vymazat pojištěného");
            Console.WriteLine("5 - Konec");
            volba = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (volba)
            {
                case '1':
                    evidencePojistenych.PridejPojistence();
                    break;
                case '2':
                    evidencePojistenych.Vypis();
                    break;
                case '3':
                    evidencePojistenych.VyhledejPojistence();
                    break;
                case '4':
                    evidencePojistenych.VymazPojistence();
                    break;
                case '5':
                    Console.WriteLine("Libovolnou klávesou ukončíte program...");
                    break;
                default:
                    Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                    break;
            }
            Console.ReadKey();
        }
    }
}