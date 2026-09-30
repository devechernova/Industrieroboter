using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter.Models;

public class Greifer : Werkzeug
{
    public Greifer(string art, int verschleiss) : base(art, verschleiss)
    {
    }

    public override string Ausgeben()
    {
        return "Greifer (Verschleiss "
            + verschleiss
            + " %).";
    }
}
