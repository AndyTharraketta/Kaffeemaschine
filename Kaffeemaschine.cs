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
        private int wasserstand;
        private int bohnenmenge;

        public static int maxWasserstand = 2000;        // Max Wasserfüllmenge in ml
        public static int maxBohnenmenge = 400;         // Max Bohnenfüllmenge in g

        public int Wasserstand { get => wasserstand; set => wasserstand = value; }      // via Rechtsklick eingefügt
        public int Bohnenmenge { get => bohnenmenge; set => bohnenmenge = value; }      // via Rechtsklick eingefügt

        public Kaffeemaschine(int wasserstand, int bohnenmenge)
        {
            this.wasserstand = wasserstand;
            this.bohnenmenge = bohnenmenge;
        }

       
        public int WasserstandAuffuellen()
        {
            return maxWasserstand - wasserstand;
        }
        
        public int BohnenmengeAuffuellen()
        {
            return maxBohnenmenge - bohnenmenge;
        }


        public void Makecoffee(int wasser, int bohnen)
        {
            Console.WriteLine($"\t1x Kaffee:\t{wasser} ml Wasser\n\t\t\t{bohnen} g Bohnen");        // Ausgabe für 1x Kaffee
        }


        




    }
}
