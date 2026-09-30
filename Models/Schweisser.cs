using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter.Models;

public class Schweisser : Werkzeug
{
    public Schweisser(string art, int verschleiss) : base(art, verschleiss)
    {
    }

    public override void Ausgeben()
    {
        Console.WriteLine("Schweisser (Verschleiss " + verschleiss + " %)");
    }
}
