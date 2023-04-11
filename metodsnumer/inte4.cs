using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public class inte4
    {
        public inte4(int interacion, double xi,  double error)
        {
            this.interacion = interacion;
            this.xi = xi;
     
            this.error = error;
        }

        public int interacion { get; set; }
        public double xi { get; set; }

        public double error { get; set; }
    }
}
