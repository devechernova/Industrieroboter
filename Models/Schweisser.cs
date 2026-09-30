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

    public override string Ausgeben()
    {
        return "Schweisser (Verschleiss "
            + verschleiss
            + " %).";
    }
}
