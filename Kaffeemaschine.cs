using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    internal class Kaffeemaschine
    {
        // Selbstversuch
        //private int wasserstand;
        //private int bohnenmenge;

        //public static int maxWasserstand = 2000;        // Max Wasserfüllmenge in ml
        //public static int maxBohnenmenge = 400;         // Max Bohnenfüllmenge in g

        //public int Wasserstand { get => wasserstand; set => wasserstand = value; }      // via Rechtsklick eingefügt
        //public int Bohnenmenge { get => bohnenmenge; set => bohnenmenge = value; }      // via Rechtsklick eingefügt

        //public Kaffeemaschine(int wasserstand, int bohnenmenge)
        //{
        //    this.wasserstand = wasserstand;
        //    this.bohnenmenge = bohnenmenge;
        //}


        //public int WasserstandAuffuellen()
        //{
        //    return maxWasserstand - wasserstand;
        //}

        //public int BohnenmengeAuffuellen()
        //{
        //    return maxBohnenmenge - bohnenmenge;
        //}


        //public void Makecoffee(int wasser, int bohnen)
        //{
        //    Console.WriteLine($"\t1x Kaffee:\t{wasser} ml Wasser\n\t\t\t{bohnen} g Bohnen");        // Ausgabe für 1x Kaffee
        //}

        //// Prüfung ob genug Material vorhanden ist
        //public bool CheckWasser()
        //{
        //    if (Kaffeemaschine.maxWasserstand >= this.wasserstand)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        //public bool CheckBohnen()
        //{
        //    if (Kaffeemaschine.maxBohnenmenge >= this.bohnenmenge)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        // Korrektur

        // Deklaration der Felder die für unsere Kaffemaschine-Objekte gebraucht werden.
        // Da kein Zugriffsmodifikator davor steht gelten die Felder als private.
        // Was im Zuge der Datenkapselung auch so sein sollte.
        int wasserstand;
        int bohnenmenge;

        // Die folgenden Felder sind statische Felder. Das bedeutet sie sind für alle Objekte dieser Klasse gleich.
        // Kein Objekt hat dafür einen individuellen Wert.
        static int maxWasserstand = 100;
        static int maxBohnenmenge = 100;

        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
        public int Bohnenmenge { get => bohnenmenge; set => bohnenmenge = value; }
        public static int MaxWasserstand { get => maxWasserstand; }
        public static int MaxBohnenmenge { get => maxBohnenmenge; }

        public Kaffeemaschine(int wasserstand, int bohnenmenge)
        {
            this.wasserstand = wasserstand;
            this.bohnenmenge = bohnenmenge;
        }

        // Zwei Methoden die jeweils Wasser bzw. Bohnen auf das Maximum auffüllen.

        public void WasserAuffuellen()
        {
            int auffuelmenge =  MaxWasserstand - wasserstand;
            wasserstand = maxWasserstand;
            Console.WriteLine($"Ihr neuer Wasserstand ist {wasserstand} Einheiten.\nEs wurden dafür {auffuelmenge} Einheiten Wasser gebraucht.");
            Console.ReadKey();
        }

        public void BohnenAuffuellen()
        {
            int auffuelmenge = MaxBohnenmenge - bohnenmenge;
            bohnenmenge = MaxBohnenmenge;
            Console.WriteLine($"Ihr neue Bohnenmenge ist {bohnenmenge} Einheiten.\nEs wurden dafür {auffuelmenge} Einheiten Bohnen gebraucht.");
            Console.ReadKey();

        }

        private bool WasserstandPruefung()
        {
            if (wasserstand >= 20) return true;
            else return false;
        }

        private bool BohnenmengenPruefung()
        {
            if (bohnenmenge >= 2) return true;
            else return false ;
        }


        // Es folgt die Methode um einen Kaffee zu machen.

        public void KaffeeZapfen()
        {
            if(WasserstandPruefung() && BohnenmengenPruefung())
            {
                wasserstand -= 20;
                bohnenmenge -= 2;
                Console.WriteLine("Hier bitte, Ihr Kaffe.");
            }
            else if(!WasserstandPruefung() && BohnenmengenPruefung()) Console.WriteLine("Bitte Wasser auffüllen!");
            else if(!BohnenmengenPruefung() && WasserstandPruefung()) Console.WriteLine("Bitte Bohnen auffüllen!");
            else Console.WriteLine("Bitte Wasser und Bohnen auffüllen!");     
            Console.ReadKey();

        }

        public void KaffeeMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Senseo Kaffeemaschine 1.0\n\nWasserstand: {wasserstand} Einheiten\tBohnenmenge: {bohnenmenge} Einheiten\n\n");
                Console.WriteLine("Bitte machen Sie eine Eingabe:\n\t1 - Kaffee machen\n\t2 - Wasser auffüllen\n\t3 - Bohnen auffüllen");
                Console.Write("Eingabe: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "1") KaffeeZapfen();
                else if (eingabe == "2") WasserAuffuellen();
                else if (eingabe == "3") BohnenAuffuellen();
                else
                {
                    Console.WriteLine("Falsche Eingabe!");
                    Console.ReadKey();
                }
            }
        }


    }
}
