using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public  class interacion
    {
        public interacion(int noIteracion, double? a, double? b, double? m, double? fa, double? fb, double? fm, string nuevoIntervalo, double? error)
        {
            NoIteracion = noIteracion;
            this.a = a;
            this.b = b;
            this.m = m;
            this.fa = fa;
            this.fb = fb;
            this.fm = fm;
            NuevoIntervalo = nuevoIntervalo;
            Error = error;
        }

        public int NoIteracion { get; set; }
        public double? a { get; set; }
        public double? b { get; set; }
        public double? m { get; set; }
        public double? fa { get; set; }
        public double? fb { get; set; }
        public double? fm { get; set; }
        public string NuevoIntervalo { get; set; }
        public double? Error { get; set; }
    }
}
