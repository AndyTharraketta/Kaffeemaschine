namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1:
            //Erstellen Sie die Klasse Kaffeemaschine.
            //Diese soll über die Felder "wasserstand" und "bohnenMenge" verfügen.
            //Es soll auch zwei static Felder (googeln Sie bitte was static bedeutet und 
            //wie es eingesetzt wird) geben namens "maxWasserstand" und "maxBohnenmenge".
            //Die Klasse soll im Sinne der Datensicherheit gekapselt sein.
            //Erstellen Sie zwei Methoden, welche jeweils zurückmelden wieviel Wasser und wieviele Bohnen aufgefüllt werden müssen.
            //Hinweis: Sie werden dann selbst ein Objekt der Klasse Kaffeemaschine erstellen müssen, dem Sie beliebig entsprechende Werte
            //zuweisen und mit dem Sie dann die Methoden ausführen können.
            //
            //Aufgabe 2:
            //Erstellen Sie eine Methode um einen Kaffee zu machen. Dafür soll eine bestimmte Menge Wasser und eine bestimmte Menge Bohnen
            //verbraucht werden.
            //Geben Sie den Kaffee stellvertretend über einen Console.WriteLine aus.
            //
            //Aufgabe 3:
            //Erstellen Sie Methoden um zu prüfen, ob noch ausreichend Wasser und Bohnen für einen Kaffe vorhanden sind.
            //Diese beiden Methoden sollen dann in der für Aufgabe 2 erstellten Methode sinnvoll aufgerufen werden. 
            //
            //Aufgabe 4a: Schreiben Sie Code der es uns ermöglicht wieder und wieder einen Kaffe aus der Maschine zu bekommen.
            //Aufgabe 4b: Machen Sie diesen Code zu einer Methode der Klasse.
            //Aufgabe 4c: Verlagern Sie alle bisherigen Methodenaufrufe aus der Programm.cs in die Methode aus 4b.
            //Diese Methode soll es dann ermöglichen nach Nutzereingabe entweder einen Kaffe zu bekommen oder eine der Auffüllmethoden auszuführen.

            // 200ml Wasser - 20g Bohnen -> pro Kaffee Tasse
            Kaffeemaschine coffeeMaker1 = new Kaffeemaschine(800,200);
            Kaffeemaschine coffeeMaker2 = new Kaffeemaschine();

            Console.WriteLine($"Test: {coffeeMaker1.Wasserstand} und {coffeeMaker1.Bohnenmenge}");






        }
    }
}
