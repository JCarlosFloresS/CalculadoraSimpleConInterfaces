using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class CSuma:IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        //Metodos a implementar
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es:{0}", r);
        }

        //Metodos propios de la clase
        public void mostrarResultados()
        {
            foreach (double r in resultados)
                Console.WriteLine(r);
        }

    }
}
