using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shop = new List<string>();
            List<string> cosulMeu = new List<string>();
            string[] optiuni = { "Shop", "Cos", "Exit" };

            shop.Add("Pen");
            shop.Add("Radiera");
            shop.Add("Penar");
            shop.Add("Caiet");
            shop.Add("Tempera");
            shop.Add("Back");

            cosulMeu.Add("Back");

            for (int i = 0; i < optiuni.Length; i++)
            {
                Console.WriteLine(optiuni[i]);
            }
            Console.WriteLine("\n");
            string nume = Console.ReadLine();
            for (int k = 0; k < k + 1; k++)
            {
                if (nume.Equals("Shop"))
                {
                    Console.WriteLine();
                    for (int i = 0; i < shop.Count; i++)
                    {
                        shop.ForEach(Console.WriteLine);
                        break;
                    }
                    Console.WriteLine();
                    nume = Console.ReadLine();
                    for (int j = 0; j < j + 1; j++)
                    {
                        if (nume.Equals("Pen"))
                        {
                            Console.WriteLine("A-ti adaugat " + nume + " in cos!");
                            cosulMeu.Add(nume);
                            Console.WriteLine();
                            for (int i = 0; i < shop.Count; i++)
                            {
                                shop.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();

                        }
                        else if (nume.Equals("Radiera"))
                        {
                            Console.WriteLine("A-ti adaugat " + nume + " in cos!");
                            cosulMeu.Add(nume);
                            Console.WriteLine();
                            for (int i = 0; i < shop.Count; i++)
                            {
                                shop.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();
                        }
                        else if (nume.Equals("Penar"))
                        {
                            Console.WriteLine("A-ti adaugat " + nume + " in cos!");
                            cosulMeu.Add(nume);
                            Console.WriteLine();
                            for (int i = 0; i < shop.Count; i++)
                            {
                                shop.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();
                        }
                        else if (nume.Equals("Caiet"))
                        {
                            Console.WriteLine("A-ti adaugat " + nume + " in cos!");
                            cosulMeu.Add(nume);
                            Console.WriteLine();
                            for (int i = 0; i < shop.Count; i++)
                            {
                                shop.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();
                        }
                        else if (nume.Equals("Tempera"))
                        {
                            Console.WriteLine("A-ti adaugat " + nume + " in cos!");
                            cosulMeu.Add(nume);
                            Console.WriteLine();
                            for (int i = 0; i < shop.Count; i++)
                            {
                                shop.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();
                        }
                        else if (nume.Equals("Back"))
                        {
                            Console.WriteLine();
                            for (int i = 0; i < optiuni.Length; i++)
                            {
                                Console.WriteLine(optiuni[i]);
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();
                        }
                        else if (nume.Equals("Cos"))
                        {
                            Console.WriteLine();
                            for (int i = 0; i < cosulMeu.Count; i++)
                            {
                                cosulMeu.ForEach(Console.WriteLine);
                                break;
                            }
                            Console.WriteLine();
                            nume = Console.ReadLine();

                        }
                        else if (nume.Equals("Exit"))
                        {
                            Environment.Exit(1);
                        }
                    }

                }
                else if (nume.Equals("Cos"))
                {
                    Console.WriteLine();
                    for (int i = 0; i < cosulMeu.Count; i++)
                    {
                        cosulMeu.ForEach(Console.WriteLine);
                        break;
                    }
                    Console.WriteLine();
                    nume = Console.ReadLine();

                }
                else if (nume.Equals("Exit"))
                {
                    Environment.Exit(1);
                }
            }



        }
    }
}
