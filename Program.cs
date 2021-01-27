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

            Console.WriteLine("Che albero vuoi, piantare?");//Il programma chiede che albero l'utente vuole piantare
            string albero = "";//Variabile per l'inserimento del nome dell'albero 
            albero = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Sei sicuro del nome dell'albero? Digita Sì o No");//Il programma chiede se l'utente ha inserito in modo corretto il nome dell'albero 
            string risposta = "";//Variabile per l'inserimento della risposta
            risposta = Convert.ToString(Console.ReadLine());
            while ((risposta == "no") | (risposta == "NO") | (risposta == "No") | (risposta == "nO"))//Ciclo per richiedere il nome dell'albero nel caso la risposta sia stata "no"
            {
                Console.WriteLine("Che albero vuoi, piantare?");
                string Albero = "";
                Albero = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Sei sicuro del nome dell'albero? Digita Sì o No");
                string Risposta = "";
                Risposta = Convert.ToString(Console.ReadLine());
                if ((Risposta == "sì") | (Risposta == "Sì") | (Risposta == "Si") | (Risposta == "SI")|(Risposta=="si"))//Se la risposta è "si" si esce dal ciclo
                {
                    break;
                }
            }
            Console.Clear();//Viene "pulita" la console dalle scritte precedenti 
                    Console.WriteLine("Inserisci la data in cui è stato piantato");//Viene chiesto in che data l'albero è stato piantato
                    var userInput = Console.ReadLine();//Viene richeista la data
                    DateTime result;
                    DateTime.TryParse(userInput, out result);
                    if (!result.Equals(DateTime.MinValue))//Controllo se la data è valida o no
                    {
                        Console.WriteLine("\nInserire tra quanti mesi si deve potare l'albero");//Il programma chiede tra quanti mesi bisogna potare l'albero
                        int meseP = Convert.ToInt32(Console.ReadLine());//Variabile per l'inserimento dei mesi di potatura
                        DateTime mesePot = result.AddMonths(meseP);//Viene calcolata la data in cui è prevista la potatura
                        Console.WriteLine("L'azione della potatura è prevista per il: {0}", mesePot);//Viene visualizzato in schermo la data
                        Console.WriteLine("\nInserire tra quanti mesi bisogna raccogliere");//Il programma chiede tra quanti mesi bisogna raccogliere
                        int meseR = Convert.ToInt32(Console.ReadLine());//Variabile per l'inserimento dei mesi di raccolta
                        DateTime meseRac = result.AddMonths(meseR);//Viene calcolata la data in cui è prevista la raccolta
                        Console.WriteLine("L'azione della raccolta è prevista per il: {0} ", meseRac);//Viene visualizzato in schermo la data
                        Console.WriteLine("\nInserire tra quanti mesi bisogna dare il pesticida");//Il programma chiede tra quanti mesi bisogna somministrare il pesticida
                        int mesePes = Convert.ToInt32(Console.ReadLine());//Variabile per l'inserimento dei mesi per la somministrazione dei pesticidi 
                        DateTime mesePesticida = result.AddMonths(mesePes);//Viene calcolata la data in cui è prevista la somministrazione dei pesticidi
                        Console.WriteLine("La data per la somministrazione di pesticidi è prevista per il: {0} ", mesePesticida);//Viene visualizzato in schermo la data
                        Console.WriteLine("\nInserire tra quanti mesi bisogna somministrare i fertilizzanti");//Il programma chiede tra quanti mesi bisogna somministrare i fertilizzanti  
                        int meseF = Convert.ToInt32(Console.ReadLine());//Variabile per l'inserimento dei mesi di raccolta
                        DateTime meseFer = result.AddMonths(meseF);//Viene calcolata la data in cui è prevista la sooministrazione dei fertilizzanti 
                        Console.WriteLine("La data per la somministrazione dei fertilizzanti è prevista per il: {0} ", meseFer);//Viene visualizzato in schermo la data
                        Console.WriteLine("\nTra quanti anni la pianta morirà?");//Il programma chiede tra quanti anni la pianta morirà
                        int annoV = Convert.ToInt32(Console.ReadLine());//Variabile per l'inserimento degli anni di vita
                        DateTime anniVita = result.AddYears(annoV);//Viene calcolata la data in cui la pianta morirà
                        Console.WriteLine("La morte della pianta è prevista per il: {0}", anniVita);//Viene visualizzato in schermo la data

            }
                    else
                    {
                        Console.WriteLine("Data inserita non valida");//Viene visualizzato su schermo ceh la data inserita non è valida
                    }


                }
            }
        }
    

   



