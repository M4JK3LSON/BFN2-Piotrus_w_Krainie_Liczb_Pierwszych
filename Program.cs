using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFN2___Piotruś_w_Krainie_Liczb_Pierwszych
{
    class Program
    {
        public static int licznikLiczbPierwszych(int poczatek, int koniec)
        {
            int[] tablica_liczb_pierwszych = new int[koniec - poczatek];
            for(int m = 0; m < tablica_liczb_pierwszych.Length; m++)
            {
                tablica_liczb_pierwszych[m] = 0;
            }
            int counter=0;
            int dzielniki = 0;
            for(double i = poczatek; i <= koniec; i++)
            {
               for(double j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        dzielniki++;
                    }
                }
                if (dzielniki == 2)
                {
                    Console.WriteLine(i);
                    counter++;
                    dzielniki = 0;
                }
                else
                {
                    dzielniki = 0;
                }
            }


            return counter;
        }
        static void Main(string[] args)
        {
            
            Console.Write("Podaj liczbę przypadków testowych (<= 150)");
            int t = int.Parse(Console.ReadLine());
            int[] tablica_wynikow = new int[t];
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Podaj liczby do testu nr {0} Liczba 1 to dolna granica 2 to górna granica. Oddziel spacją.",i);
                string linia = Console.ReadLine();
                string[] splitted = linia.Split(' ');
                int L = int.Parse(splitted[0]);
                int U = int.Parse(splitted[1]);
                tablica_wynikow[i] = licznikLiczbPierwszych(L, U);


            }
            for(int k = 0; k < tablica_wynikow.Length; k++)
            {
                Console.WriteLine("Dla testu {0} Liczb Pierwszych w przedzialej jest: {1}", k, tablica_wynikow[k]);
            }
            Console.ReadKey();
        }
    }
}
