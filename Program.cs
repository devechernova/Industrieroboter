using Industrieroboter.Models;

namespace Industrieroboter;

internal class Program
{
    static void Main(string[] args)
    {
        Models.Industrieroboter roboter = new Models.Industrieroboter();

        Bohrer bohrer1 = new Bohrer("Bohrer", 0, 10);
        Bohrer bohrer2 = new Bohrer("Bohrer", 0, 10);

        /*  roboter.WerkzeugHinzufuegen(bohrer1, 5);
          roboter.WerkzeugHinzufuegen(bohrer2, 5);
          roboter.WerkzeugHinzufuegen(bohrer2, 10);
          roboter.WerkzeugHinzufuegen(bohrer2, -1);

          roboter.WerkzeugEntfernen(5);
          roboter.WerkzeugEntfernen(5);
          roboter.WerkzeugEntfernen(10);
          roboter.WerkzeugEntfernen(-1);*/

        bool beenden = false;
        while (!beenden)
        {
            Console.WriteLine();
            Console.WriteLine("=== Werkzeugkasten-Verwaltung ===");
            Console.WriteLine("1. Werkzeug hinzufügen");
            Console.WriteLine("2. Werkzeug entfernen");
            Console.WriteLine("3. Werkzeugkasten anzeigen");
            Console.WriteLine("4. Werkzeug benutzen");
            Console.WriteLine("5. Werkzeug warten");
            Console.WriteLine("6. Beenden");

            Console.WriteLine("\nAuswahl: ");

            int auswahl = Convert.ToInt32(Console.ReadLine());

            switch (auswahl)
            {
                case 1:

                    Console.Write("Platz: ");
                    int platz = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1. Bohrer");
                    Console.WriteLine("2. Greifer");
                    Console.WriteLine("3. Schweisser");

                    Console.Write("Werkzeugtyp: ");
                    int werkzeugTyp = Convert.ToInt32(Console.ReadLine());

                    if (werkzeugTyp == 1)
                    {
                        Bohrer bohrer = new Bohrer("Bohrer", 0, 10);
                        roboter.WerkzeugHinzufuegen(bohrer, platz);
                    }
                    else if (werkzeugTyp == 2)
                    {
                        Greifer greifer = new Greifer("Greifer", 0);
                        roboter.WerkzeugHinzufuegen(greifer, platz);
                    }
                    else if (werkzeugTyp == 3)
                    {
                        Schweisser schweisser = new Schweisser("Schweisser", 0);
                        roboter.WerkzeugHinzufuegen(schweisser, platz);
                    }
                    else
                    {
                        Console.WriteLine("Ungueltige Werkzeugauswahl.");
                    }

                    break;

                case 2:
                    Console.Write("Platz: ");
                    int platzZumEntfernen = Convert.ToInt32(Console.ReadLine());

                    roboter.WerkzeugEntfernen(platzZumEntfernen);
                    break;

                case 3:
                    roboter.WerkzeugkastenAnzeigen();
                    break;

                case 4:
                    Console.WriteLine("Werkzeug benutzen");
                    break;

                case 5:
                    Console.WriteLine("Werkzeug warten");
                    break;

                case 6:
                    beenden = true;
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }
    }
}
