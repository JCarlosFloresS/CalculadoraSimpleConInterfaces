using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class CResta:IOperacion
    {
        private double r = 0;

        //Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a - b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resuñtado de la resta es:{0}", r);
        }
    }
}
