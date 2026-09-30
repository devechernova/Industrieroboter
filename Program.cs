using Industrieroboter.Models;

namespace Industrieroboter;

internal class Program
{
    static void Main(string[] args)
    {
        Models.Industrieroboter roboter = new Models.Industrieroboter();

        Bohrer bohrer1 = new Bohrer("Bohrer", 0, 10);
        Bohrer bohrer2 = new Bohrer("Bohrer", 0, 10);

        roboter.WerkzeugHinzufuegen(bohrer1, 5);
        roboter.WerkzeugHinzufuegen(bohrer2, 5);
        roboter.WerkzeugHinzufuegen(bohrer2, 10);
        roboter.WerkzeugHinzufuegen(bohrer2, -1);

        roboter.WerkzeugEntfernen(5);
        roboter.WerkzeugEntfernen(5);
        roboter.WerkzeugEntfernen(10);
        roboter.WerkzeugEntfernen(-1);
    }
}
