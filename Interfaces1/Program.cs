using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;

            string valor = "";

            IOperacion operacion = new CSuma();

            while(opcion != 5)
            {
                Console.WriteLine("Seleccione la operación que desea realizar");
                Console.WriteLine("1-->Suma  2-->Resta  3-->Multiplicación  4-->Division  5-->Salir");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Ingrese el primer valor");
                valor = Console.ReadLine();
                vala = Convert.ToDouble(valor);

                Console.WriteLine("Ingrese el segundo valor");
                valor = Console.ReadLine();
                valb = Convert.ToDouble(valor);

                //Polimorfismo
                if (opcion == 1)
                    operacion = new CSuma();
                if (opcion == 2)
                    operacion = new CResta();
                if (opcion == 3)
                    operacion = new CMulti();
                if (opcion == 4)
                    operacion = new CDiv();

                //El programa trabaja en terminos del concepto de operacion y no en terminos de suma, resta, multiplicacion, division

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }
        }
    }
}
