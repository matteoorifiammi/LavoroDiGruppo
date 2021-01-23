using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_inserimento_alberi
{
    class Program
    {
        static void Main(string[] args)
        {
            aggiuntaAlberi();
            Console.ReadKey();
        }
        static void aggiuntaAlberi()
        {

            Console.WriteLine("Che albero vuoi, piantare?");
            string albero = "";
        albero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Inserisci la data in cui è stato piantato");
            var userInput = Console.ReadLine();
        DateTime result;
        DateTime.TryParse(userInput, out result);
            if (!result.Equals(DateTime.MinValue))
            {
                Console.WriteLine("\nInserire tra quanti mesi si deve potare l'albero");
                int meseP = Convert.ToInt32(Console.ReadLine());
        DateTime mesePot = result.AddMonths(meseP);
        Console.WriteLine("L'azione della potatura è prevista per il: {0}", mesePot);
                Console.WriteLine("\nInserire tra quanti mesi bisogna raccogliere");
                int meseR = Convert.ToInt32(Console.ReadLine());
        DateTime meseRac = result.AddMonths(meseR);
        Console.WriteLine("L'azione della raccolta è prevista per il: {0} ", meseRac);
                Console.WriteLine("\nInserire tra quanti mesi bisogna dare il pesticida");
                int mesePes = Convert.ToInt32(Console.ReadLine());
        DateTime mesePesticida = result.AddMonths(mesePes);
        Console.WriteLine("La data per la somministrazione di pesticidi è prevista per il: {0} ", mesePesticida);
                Console.WriteLine("\nInserire tra quanti mesi bisogna somministrare i fertilizzanti");
                int meseF = Convert.ToInt32(Console.ReadLine());
        DateTime meseFer = result.AddMonths(meseF);
        Console.WriteLine("La data per la somministrazione dei fertilizzanti è prevista per il: {0} ", meseFer);
                Console.WriteLine("\nTra quanti anni la pianta morirà?");
                int annoV = Convert.ToInt32(Console.ReadLine());
        DateTime anniVita = result.AddYears(annoV);
        Console.WriteLine("La morte della pianta è prevista per il: {0}", anniVita);
            }
            else
            {
                Console.WriteLine("Data inserita non valida");
            }
            
        }
    }
}
