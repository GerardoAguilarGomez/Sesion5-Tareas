using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio7
    {
        public void Conversor()
        {

            Console.WriteLine("Inserte cantidad de EUROS: ");
            string Eu = Console.ReadLine();

            Console.WriteLine("Inserte a que moneda lo quiere convertir: DOLAR - LIBRA - YEN ");
            string Moneda = Console.ReadLine();

            Console.WriteLine("El resultado es {0}", Cambio(Eu, Moneda));

        }

        public double Cambio(string Num, string Mon)
        {
            double resultado = 0;
            int Numero = Convert.ToInt32(Num);
            switch (Mon)
            {
                case "DOLAR":
                    resultado = Numero * 1.28611;
                    break;
                case "LIBRA":
                    resultado = Numero * 0.86;
                    break;
                case "YEN":
                    resultado = Numero * 129.852;
                    break;
            }

            return resultado;
        }
    }
}
