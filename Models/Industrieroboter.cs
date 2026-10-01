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
    + werkzeug.Ausgeben());

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
    + entferntesWerkzeug.Ausgeben());

        return true;
    }
    public void WerkzeugkastenAnzeigen()
    {
        for (int i = 0; i < maxAnzWerkzeuge; i++)
        {
            if (werkzeugkasten[i] == null)
            {
                Console.WriteLine("Platz " + i + ": leer");
            }
            else
            {
                Console.WriteLine(
                    "Platz "
                    + i
                    + ": "
                    + werkzeugkasten[i].Ausgeben()
                );
            }
        }
    }

    public void WerkzeugBenutzen(int platz, int wert)
    {
        if (platz < 0 || platz >= maxAnzWerkzeuge)
        {
            Console.WriteLine(
                "Benutzen nicht moeglich, da Platz "
                + platz
                + " nicht existiert."
            );

            return;
        }

        if (werkzeugkasten[platz] == null)
        {
            Console.WriteLine(
                "Benutzen nicht moeglich, da Platz "
                + platz
                + " leer ist."
            );

            return;
        }

        werkzeugkasten[platz].Benutzen(wert);

        Console.WriteLine(
            "Werkzeug auf Platz "
            + platz
            + " wurde benutzt."
        );
    }

    public void WerkzeugWarten(int platz)
    {
        if (platz < 0 || platz >= maxAnzWerkzeuge)
        {
            Console.WriteLine(
                "Wartung nicht moeglich, da Platz "
                + platz
                + " nicht existiert."
            );

            return;
        }

        if (werkzeugkasten[platz] == null)
        {
            Console.WriteLine(
                "Wartung nicht moeglich, da Platz "
                + platz
                + " leer ist."
            );

            return;
        }

        werkzeugkasten[platz].Warten();

        Console.WriteLine(
            "Werkzeug auf Platz "
            + platz
            + " wurde gewartet."
        );
    }

    public void StatistikAnzeigen()
    {
        int freiePlaetze = 0;
        int belegtePlaetze = 0;

        int gesamtVerschleiss = 0;

        Werkzeug? staerkstesWerkzeug = null;
        int maxVerschleiss = -1;

        for (int i = 0; i < maxAnzWerkzeuge; i++)
        {
            if (werkzeugkasten[i] == null)
            {
                freiePlaetze++;
            }
            else
            {
                belegtePlaetze++;

                gesamtVerschleiss +=
werkzeugkasten[i].GetVerschleiss();


                if (werkzeugkasten[i].GetVerschleiss() > maxVerschleiss)
                {
                    maxVerschleiss =
                        werkzeugkasten[i].GetVerschleiss();

                    staerkstesWerkzeug =
                        werkzeugkasten[i];
                }
            }

        }

            double durchschnittlicherVerschleiss = 0;

            if (belegtePlaetze > 0)
            {
                durchschnittlicherVerschleiss =
                    (double)gesamtVerschleiss / belegtePlaetze;
            }

            Console.WriteLine("Freie Plaetze: " + freiePlaetze);
            Console.WriteLine("Belegte Plaetze: " + belegtePlaetze);
            Console.WriteLine("Gesamtverschleiss: " + gesamtVerschleiss);
            Console.WriteLine("Durchschnittlicher Verschleiss: " + durchschnittlicherVerschleiss);

            if (staerkstesWerkzeug != null)
            {
                Console.WriteLine(
                    "Staerkst verschlissenes Werkzeug: "
                    + staerkstesWerkzeug.Ausgeben());
            }
        
    }
}



