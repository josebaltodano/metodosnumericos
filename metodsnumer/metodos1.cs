using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodsnumer
{
    public static class metodos1
    {

        public static List<interacion> MetodoBiseccion(double a, double b, double tolerancia)
        {
            List<interacion> iteraciones = new List<interacion>();
           
            double fa = 0, fb = 0, fm = 0;
            double error = double.MaxValue;
            int contador = 1;
            while (error > tolerancia)
            {
                double m = (a + b) / 2;
                //fa = 2 * Math.Exp(Math.Pow(a, 2)) - 5 * a;
                //fb = 2 * Math.Exp(Math.Pow(b, 2)) - 5 * b;
                //fm = 2 * Math.Exp(Math.Pow(m, 2)) - 5 * m;
                //fa = Math.Pow(a, 4) - 2 * Math.Pow(a, 3) - 12 * Math.Pow(a, 2) - 16 * a - 40;
                //fb = Math.Pow(b, 4) - 2 * Math.Pow(b, 3) - 12 * Math.Pow(b, 2) - 16 * b - 40;
                //fm = Math.Pow(m, 4) - 2 * Math.Pow(m, 3) - 12 * Math.Pow(m, 2) - 16 * m - 40;
                fa = Math.Exp(-0.2 * a) * Math.Sin(3 * a - 0.5);
                fb = Math.Exp(-0.2 * b) * Math.Sin(3 * b - 0.5);
                fm = Math.Exp(-0.2 * m) * Math.Sin(3 * m - 0.5);

                //fa = 2 * Math.Pow(Math.E, Math.Pow(a, 2)) - 5 * a;
                //fb = 2 * Math.Pow(Math.E, Math.Pow(b, 2)) - 5 * b;
                //fm = 2 * Math.Pow(Math.E, Math.Pow(m, 2)) - 5 * m;

                //fa = Math.Log(Math.Pow(a, 2)) - 1;
                //fb = Math.Log(Math.Pow(b, 2)) - 1;
                //fm = Math.Log(Math.Pow(m, 2)) - 1;

                //fa = Math.Pow(Math.E, -0.2 * a) * Math.Sin(3 * a - 0.5);
                //fb = Math.Pow(Math.E, -0.2 * b) * Math.Sin(3 * b - 0.5);
                //fm = Math.Pow(Math.E, -0.2 * m) * Math.Sin(3 * m - 0.5);

                double nuevoIntervalo = (fa * fm < 0) ? a : b;
                error = (b - a) / 2;
                string intervalo = (nuevoIntervalo == a) ? "[" + a + " , " + m + "]" : "[" + m + " , " + b + "]";
                iteraciones.Add(new interacion(contador, a, b, m, fa, fb, fm, intervalo, error));
                if (nuevoIntervalo > m)
                    a = m;
                else if (nuevoIntervalo < m)
                    b = m;
                contador++;


            }
            return iteraciones;
        }


        public static List<interacion> MetodoReglaFalsa( double a, double b, double tolerancia)
        {
            List<interacion> iteraciones = new List<interacion>();
         
            double xanterior, x = 0;
            double fa, fb, fx, aoriginal, boriginal;
            double error = double.MaxValue;
            double? primerError = null;
            int cont = 1;
            while (error > tolerancia)
            {
                //fa = 2 * Math.Exp(Math.Pow(a, 2)) - 5 * a;
                //fb = 2 * Math.Exp(Math.Pow(b, 2)) - 5 * b;

                //fa = Math.Log(Math.Pow(a, 2)) - 1;
                //fb = Math.Log(Math.Pow(b, 2)) - 1;

                //fa = 2 * Math.Exp(Math.Pow(a, 2)) - 5 * a;
                //fb = 2 * Math.Exp(Math.Pow(b, 2)) - 5 * b;

                fa = Math.Pow(Math.E, -0.2 * a) * Math.Sin(3 * a - 0.5);
                fb = Math.Pow(Math.E, -0.2 * b) * Math.Sin(3 * b - 0.5);

                ////fa = Math.Pow(a, 4) - 2 * Math.Pow(a, 3) - 12 * Math.Pow(a, 2) - 16 * a - 40;
                //fa = Math.Pow(a, 10) - 2;
                ////fb = Math.Pow(b, 4) - 2 * Math.Pow(b, 3) - 12 * Math.Pow(b, 2) - 16 * b - 40;
                //fb = Math.Pow(b, 10) - 2;
                xanterior = x;
                x = ((a * fb) - (b * fa)) / (fb - fa);
                //fx = Math.Pow(x, 4) - 2 * Math.Pow(x, 3) - 12 * Math.Pow(x, 2) - 16 * x - 40;
                ////fx = Math.Pow(x, 10) - 2
             ;
                //fx = 2 * Math.Exp(Math.Pow(x, 2)) - 5 * x;
                //fx = Math.Log(Math.Pow(x, 2)) - 1;
                fx = Math.Pow(Math.E, -0.2 * x) * Math.Sin(3 * x - 0.5);
                //fx = 2 * Math.Exp(Math.Pow(x, 2)) - 5 * x;

                double nuevoIntervalo = (fx * fa) < 0 ? a : b;
                string intevalo = (nuevoIntervalo == a) ? "[" + a + " , " + x + "]" : "[" + x + " , " + b + "]";
                aoriginal = a;
                boriginal = b;
                if (nuevoIntervalo > x)
                    a = x;
                else
                    b = x;

                if (cont > 1)
                    error = Math.Abs(x - xanterior);
                iteraciones.Add(new interacion(cont, aoriginal, boriginal, x, fa, fb, fx, intevalo, (cont > 1) ? error : primerError));
                cont++;
            }
            return iteraciones;
        }

        public static List<inte2> MetodoPuntoFijo( double xi, double tolerancia)
        {
            List<inte2> iteraciones = new List<inte2>();
           
            double error = double.MaxValue;
            int cont = 0;
            iteraciones.Add(new inte2(cont++, xi,error));
            while (error > tolerancia)
            {
                double xanterior = xi;
                //xi = g.calculate(xanterior);

                //ejercicio: 2e^(x^2)-5x
                xi = (2.0 / 5.0) * Math.Pow(Math.E, Math.Pow(xi, 2));
                //xi = (Math.Pow(xi, 3) + 5) / 2;
                //ejercicio: x^3-2x+5
                //xi = (Math.Pow(xi, 3) + 5) / 2.0;
                //xi = Math.Pow(Math.E, -xi);
                //xi = 1 + (1.0 / 2.0) * Math.Sin(xi);
                //xi = Math.Pow(Math.E, 3 * xi) + xi - 4;
                //xi = xi + Math.Cos(xi);
                //xi = Math.Exp(3 * xi) + xi - 4;
                //la tolerancia no la paso en porcentaje
                error = Math.Abs((xi - xanterior) / xi );
                iteraciones.Add(new inte2(cont, xi, error));
                cont++;
            }
            return iteraciones;
        }
        public static List<inte3> metodonepwtoew(double xi, double tolerancia)
        {
            List<inte3> iteracion = new List<inte3>();
            double error = double.MaxValue;
            double fxi = 0;
            double fx1 = 0;
            double funcion2 = 0;
            double fxt1 = 0;
            int cont = 0;
            //iteracion.Add(new inte3(cont++, xi, fxi, fx1, funcion2, fxt1, error));
            while (error > tolerancia)
            {
               
                double anterior = xi;
                // fxi = Math.Pow(xi,3)-xi-1;
                //fx1 = 3*Math.Pow(xi,2)-1;
                fxi = (1.0 / 2.0) * Math.Cos(xi - Math.Pow(xi, 2));
                fx1 = (-1.0 / 2.0) * Math.Sin(xi - 2 * xi);
                funcion2 = fxi / fx1;
                fxt1 = xi - funcion2;
                error = Math.Abs((fxt1 - anterior) / fxt1 );
                iteracion.Add(new inte3(cont++, xi, fxi, fx1, funcion2, fxt1, error));
                xi = fxt1;
                //cont++;
            }
            return iteracion;
        }

        public static List<inte4> metodosecante(double x1, double x0, double toleracnia)
        {
            List<inte4> iteraciones = new List<inte4>();
            double error = double.MaxValue;
            int contador = 0;
            double ximenosuno = 0;
            double ximenosunoanterior = 0;
            double xanterior = 0;
            double xmenosuno =0;
            while (error > toleracnia)
            {
              
                double fxi = n;
                double fxmenosuno = new Expression(funcion, a2).calculate();
                double ximasuno = x0 - ((fxi * (xmenosuno - x0)) / (fxmenosuno - fxi));
                double cociente = ((fxi * (ximenosuno - x0)) / (fxmenosuno - fxi));
                ximenosunoanterior = xmenosuno;
                xanterior = x0;
                xmenosuno = x0;
                x0 = ximasuno;
                error = Math.Abs((x0 - xanterior) / x0);
                iteraciones.Add(new inte4(contador, xanterior, fxi, fxmenosuno, cociente, x0, ximenosunoanterior, error));
                contador++;
            }
            return iteraciones;
        }

        public static List<muller> metodomuller(double xo,double x1,double x2 ,double tolerancia)
        {
            List<muller> mullers = new List<muller>();
            double error = double.MaxValue;
            int cont = 0;
            while (error > tolerancia)
            {
                double ho = x1 - xo;
                double h1 = x2 - x1;
                double lo = ((Math.Pow(x1, 3) - 13 * x1 - 12) - (Math.Pow(xo, 3) - 13 * xo - 12)) / ho;
                double l1 = ((Math.Pow(x2, 3) - 13 * x2 - 12) - (Math.Pow(x1, 3) - 13 * x1 - 12)) / h1;
                double a = (l1 - lo) / h1 - ho;
                double b = a * h1 + l1;
                double c = Math.Pow(x2, 3) - 13 * x2 - 12;

                double det1 = b+ ((Math.Sqrt(Math.Pow(b,2))-4*a*c));
                double det2 = b - ((Math.Sqrt(Math.Pow(b, 2)) - 4 * a * c)) ;
                double det;
             
                if (det1 > det2)
                {
                    det = det1;
                }
                else
                {
                    det = det2;
                }
                double x = (x2 )+ (- 2 * c )/ det;
                  error = Math.Abs((x - x2) / x *100);
                xo = x1;
                x1 = x2;
                x2 = x;
                mullers.Add(new muller(cont++, x, error));
              



            }
            return mullers;

        }


    }
}
// 2--
//int e = Math.Pow(e, 4) - 12 * Math.Pow(e, 2) - 16 * e - 40 ;
//e = 2 * Math.Pow(Math.E(), Math.Pow(x, 2)) - 5 * e;
//e = Math.Log(Math.Pow(e, 2) - 1 ;
//e = Math.Pow(Math.E(), -0.2 * e) * Math.Sin(3 * e - 0.5)