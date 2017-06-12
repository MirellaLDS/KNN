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
        public double distancia { get; set; }

        public Individuo(string a, string b, string c, string d, string classe)
        {
            this.a = double.Parse(a);
            this.b = double.Parse(b);
            this.c = double.Parse(c);
            this.d = double.Parse(d);
            this.classe = classe;
        }

        public Individuo()
        {            
        }

    }
}
