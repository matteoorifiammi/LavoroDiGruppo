using System;

namespace array_multidimensionali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci quanti alberi devi avere");
            int x;
            x = Convert.ToInt32(Console.ReadLine());



            string c;
            c = Convert.ToString(Console.ReadLine());

            string[,] Tabella = new string[x, 9];

            for (int a = 0; a < 9; a++)
            {

                for (int b = 0; b < x; b++)
                {
                    Console.WriteLine($"inserisci il prosimo dato{c}");
                    Tabella[b,a] = Convert.ToString(Console.ReadLine());


                }
            }



          
                for (int n=0; n<x; n++)
                {
                for (int i = 0; i < 9; i++)
                {
                    System.Console.WriteLine(Tabella[n, i]);
                }
                }
              
            

            

            Console.ReadKey();
        }
    }
}
