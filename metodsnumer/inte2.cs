using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public  class inte2
    {
        public inte2(int noIteracion, double xi, double error)
        {
            NoIteracion = noIteracion;
            this.xi = xi;
            this.error = error;
        
        }

        public int NoIteracion { get; set; }
        public double xi { get; set; }
        public double error { get; set; }

    
    }
}
