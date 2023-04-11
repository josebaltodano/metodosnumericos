using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public class muller
    {
        public muller(int iteracion, double x, double error)
        {
            this.iteracion = iteracion;
            this.x = x;
            this.error = error;
        }

        public int iteracion { get; set; }
        public double x {  get; set; }
        public double error { get; set; }
    }
}
