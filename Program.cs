using System;
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
            //string s = "Hallo";
            //s.Length
            //s [1]=
            // for (int i = 0; i < s.Length ; i++)
            // {Console.Write(s[i]);}
            //Console.WriteLine(s);
            // i = i+5;
            //i += 5;
            // i ++ <-> i = i+1;

            //for (int i =0; i< s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
                    
            // }
            //umgekehrte Reihnfolge =
            //for (int i = s.Length -1; i>=0; i--)
            //{
            //    Console.WriteLine(s[i]);

            //}
            string wiederholen;
            do
            {
                //Menü
                int auswahl;
                Console.WriteLine("1: Zeichen ersetzen.");
                Console.WriteLine("2: Vokale entfernen.");
                Console.WriteLine("3: Queersumme bilden.");
                Console.WriteLine("4: Beenden.");


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
                        //ersetzt = zuErsetzen.Replace(zeichen, ersatz);
                        // string ersetzt = ""; auch
                        for (int i = 0; i < zuErsetzen.Length; i++)
                        {
                            if (zuErsetzen[i].ToString() == zeichen)
                            {
                                ersetzt = ersetzt + ersatz;
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
                        string zeichenkette;
                        
                        Console.WriteLine("Zeichenkette eingeben:");
                        zeichenkette = Console.ReadLine();
                        string zeichenketteALT = zeichenkette;

                        //string ergebnis = "";

                        //ergebnis = zeichenkette.Replace("a", "");
                        //string ergebnis1 = ergebnis.Replace("e", "");
                        //string ergebnis2 = ergebnis1.Replace("i", "");
                        //string ergebnis3 = ergebnis2.Replace("o", "");
                        //string ergebnis4 = ergebnis3.Replace("u", "");
                        //Console.WriteLine(zeichenkette + " wird zu " + ergebnis4);

                        string vokale = "aeiouAEIOU";

                        //string ersetzt2 = "";
                        for (int i = 0; i < vokale.Length; i++)
                        {
                            zeichenkette = zeichenkette.Replace(vokale[i].ToString(), "");
                            //for (int j = 0; j < zeichenkette.Length; j++)
                            //{
                            //    if(zeichenkette[j] == vokale[i])
                            //    {
                            //        ersetzt2 += "";
                            //    }
                            //    else
                            //    {
                            //        ersetzt2 += zeichenkette[i];
                            //    }
                            //}


                        } Console.WriteLine(zeichenketteALT + " wird zu " + zeichenkette);










                            break;


                    case 3:
                        Console.WriteLine("Die Quersumme einer ganzen Zahl soll berechnet werden");
                        Console.Write("Eine ganze zehl eingeben:");
                        string zahl = Console.ReadLine();
                        int quersumme = 0;
                        for (int i = 0; i < zahl.Length; i++)
                        {
                            quersumme += Convert.ToInt32(zahl[i].ToString());
                            //quersumme = quersumme + Convert.ToInt32(zahl[i].ToString());
                        }
                        Console.WriteLine("Die Quersumme von " + zahl + " ist: " + quersumme);


                        //int Quersumme;
                        //string Zahl;
                        
                        //Console.WriteLine("Zahl eingeben");
                        //Zahl = (Console.ReadLine());
                        //for (int i = 0; i < Zahl.Length; i++)
                        //{
                        //    string Zahlj;
                        //    for (int j = 0; j < Zahlj.Length; j++)
                        //        Zahlj = Convert.ToInt32(Zahl[i] + Zahl[i + 1]);
                        //        Quersumme = Convert.ToInt32(Zahl[j] + Zahl[i + 1]);
                        //}
                        //Console.WriteLine();




                        break;









                    case 4:
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
