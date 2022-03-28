﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arbeiten mit Strings");
            string s = "Hallo";
            //s.Length
            //s [1]=
            // for (int i = 0; i < s.Length ; i++)
            // {Console.Write(s[i]);}
            Console.WriteLine(s);
            // i = i+5;
            //i += 5;
            // i ++ <-> i = i+1;

            for (int i =0; i< s.Length; i++)
            {
                Console.WriteLine(s[i]);
                    
             }
            //umgekehrte Reihnfolge =
            for (int i = s.Length -1; i>=0; i--)
            {
                Console.WriteLine(s[i]);

            }
            string wiederholen;
            do
            {
                //Menü
                int auswahl;
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Beenden.");


                Console.Write("Auswahl:");
                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Zeichen sollen ersetzt werden.");
                        string zuErsetzen, zeichen, ersatz;
                        Console.WriteLine("Zeichenkette eingeben:");
                        zuErsetzen = Console.ReadLine();
                        Console.WriteLine("Welches Zeichen soll ersetzt werden?");
                        zeichen = Console.ReadLine();
                        Console.WriteLine("Wodurch soll " + zeichen + " ersetzt werden?");
                        ersatz = Console.ReadLine();
                        Console.WriteLine("Es wird " + zeichen + " durch " + ersatz + "ersetzt:");
                        string ersetzt= string.Empty;
                        ersetzt = zuErsetzen.Replace(zeichen, ersatz);
                        // string ersetzt = ""; auch
                        for (int i = 0; i < zuErsetzen.Length; i++)
                        {
                            if (zuErsetzen[i].ToString() == zeichen)
                            {
                                ersetzt += ersatz;
                            }
                            else
                            {
                                ersetzt += zuErsetzen[i];
                            }
                        }
                        Console.WriteLine(zuErsetzen + "wird zu: " + ersetzt);





                        break;
                    case 2:
                        Console.WriteLine("Vokale sollen entfernt werden.");
                        break;
                    case 3:
                        Console.WriteLine("Programm wird beendet.");
                        
                        break;

                    default:
                        Console.WriteLine("Auswahl ungültig.");
                        break;

                }



                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
            } while (wiederholen == "j" || wiederholen == "J");


        }
    }
}
