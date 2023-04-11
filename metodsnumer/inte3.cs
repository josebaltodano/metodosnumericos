using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public class inte3
    {
        public inte3(int interacion, double xi, double fxi, double fxi1, double funcion2, double xt1, double error)
        {
            this.interacion = interacion;
            this.xi = xi;
            this.fxi = fxi;
            this.fxi1 = fxi1;
            this.funcion2 = funcion2;
            this.xt1 = xt1;
            this.error = error;
        }

        public int interacion { get; set; }
        public double xi { get; set; }
        public double fxi { get; set; }
        public double fxi1 { get; set; }
        public double funcion2 { get; set; }
        public double xt1 { get; set; }
        public double error { get; set; }
    }
}
