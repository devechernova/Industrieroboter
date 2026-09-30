using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter.Models;

public class Industrieroboter
{
    private const int maxAnzWerkzeuge = 10;
    private Werkzeug[] werkzeugkasten;

    public Industrieroboter()
    {
        werkzeugkasten = new Werkzeug[maxAnzWerkzeuge];
    }

    public bool WerkzeugHinzufuegen(Werkzeug werkzeug, int platz)
    {
        if (platz < 0 || platz >= maxAnzWerkzeuge)
        {
            Console.WriteLine("Hinzufuegen nicht moeglich, da Platz "
                +  platz
                + " nicht existiert.");

            return false;
        }

        if (werkzeugkasten[platz] != null)
        {
            Console.WriteLine("Hinzufuegen nicht moeglich, da Platz "
                + platz
                + " belegt ist.");

            return false;
        }

        werkzeugkasten[platz] = werkzeug;

        Console.WriteLine(
    "Hinzugefuegtes Werkzeug auf Platz "
    + platz
    + ": "
    + werkzeug.Ausgeben()
);

        return true;
    }

    public bool WerkzeugEntfernen(int platz)
    {
        if (platz < 0 || platz >= maxAnzWerkzeuge)
        {
            Console.WriteLine(
                "Entfernen nicht moeglich, da Platz "
                + platz
                + " nicht existiert."
            );

            return false;
        }

        if (werkzeugkasten[platz] == null)
        {
            Console.WriteLine(
                "Entfernen nicht moeglich, da Platz "
                + platz
                + " nicht belegt ist."
            );

            return false;
        }
        Werkzeug entferntesWerkzeug = werkzeugkasten[platz];
        werkzeugkasten[platz] = null;

        Console.WriteLine(
    "Entferntes Werkzeug auf Platz "
    + platz
    + ": "
    + entferntesWerkzeug.Ausgeben()
);

        return true;
    }
}
