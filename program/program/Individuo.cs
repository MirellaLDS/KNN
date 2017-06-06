using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Individuo
    {
        public string classe;
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }

        public Individuo(double a, double b, double c, double d, string classe)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.classe = classe;
        }

    }
}
