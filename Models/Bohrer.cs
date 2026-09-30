using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter.Models;

public class Bohrer : Werkzeug
{
    private int groesse;

    public Bohrer(string art, int verschleiss, int groesse):
        base(art, verschleiss)
    {
        this.groesse = groesse;
    }
    public override void Ausgeben()
    {
        Console.WriteLine("Bohrer mit Groesse" + groesse + " (Verschleiss " + verschleiss +" %)");
    }
}

