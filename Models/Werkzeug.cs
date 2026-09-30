using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrieroboter.Models;

    public class Werkzeug
    {
        private string art;
        protected int verschleiss;

        public Werkzeug(string art, int verschleiss = 0)
        {
            this.art = art;
            this.verschleiss = verschleiss;
        }

        public string Art
        {
            get { return art; }
        }

        public int Verschleiss
        {
            get { return verschleiss; }
            set
            {
                if (value < 0)
                {
                    verschleiss = 0;
                }
                else if (value > 100)
                {
                    verschleiss = 100;
                }
                else
                {
                    verschleiss = value;
                }
            }
        }

        public virtual void Ausgeben()
        {
            Console.WriteLine($"{art} (Verschleiss {verschleiss} %)");
        }
    }