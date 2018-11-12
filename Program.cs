using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primosztokFinal3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primosztokIndexer = 0;
            int[] primek = new int[25]; 
            int[] primosztok = new int[25];
            string ujra2;
            bool ujra = true;
            while (ujra == true)
            {
                try
                {
                    Console.Title = "Prímosztók meghatározása";
                    Console.Write("Adj meg egy számot: ");
                    double szam0 = Convert.ToDouble(Console.ReadLine());

                    if (szam0 < 0 && szam0 % 1 != 0)
                        Console.WriteLine("Nem pozitív egész számot adtál meg.");
                    else if (szam0 % 1 != 0)
                        Console.WriteLine("Nem egész számot adtál meg.");
                    else if (szam0 <= 0)
                        Console.WriteLine("Nem pozitív számot adtál meg.");
                    else
                    {
                        int szam = Convert.ToInt32(szam0);
                        Console.Write("A szám prímtényezős felbontását is szeretnéd elvégezni? (igen/nem): "); //ha nem, akkor csak a legnagyobbat írja ki
                        string bontas = Console.ReadLine();

                        for (int i = 2; i <= szam; i++)
                        {
                            int c = 0;
                            while (szam % i == 0)
                            {
                                c++;
                                szam /= i;
                            }
                            if (c > 0)
                            {
                                primosztok[primosztokIndexer] = i;
                                primosztokIndexer++;
                            }
                            //Console.WriteLine(i);
                            if (bontas.Contains("igen") || bontas.Contains("i"))
                            {
                                if (c >0)
                                    /*Prímtényezős felbontáshoz:*/
                                    Console.WriteLine($"{i}^{c}");
                            }
                        }
                        int legnagyobb = primosztok.Max();
                        if (legnagyobb == 0)
                        {
                            Console.WriteLine(/*"A(z) " + szam + */"Prímszám, ezért legnagyobb prímosztója " + szam + ".");
                        }
                        else
                        {
                            Console.WriteLine(/*szam + */"Legnagyobb prímosztó: " + legnagyobb);
                            Console.WriteLine(" többi prímosztói: ");
                            int k_segedindexer = 0;
                            while (primosztok[k_segedindexer] != 0 && primosztok[k_segedindexer] < legnagyobb)
                            {
                                Console.WriteLine(primosztok[k_segedindexer]);
                                k_segedindexer++;
                            }
                            //Console.WriteLine(/*szam + */"Legnagyobb prímosztó: " + legnagyobb);
                            k_segedindexer = 0;
                            primosztokIndexer = 0;
                        }
                    }
                }
                catch (Exception hiba)
                {
                    Console.WriteLine("Hiba: " + hiba.Message);
                }

                Console.Write("Szeretnél új számot megadni? (i/n): ");
                ujra2 = Console.ReadLine();
                ujra = ujra2.Contains("i");
                if (ujra == true)
                {
                    Array.Clear(primosztok, 0, primosztok.Length);
                }
                Console.Clear();
            }
        }
    }
}
