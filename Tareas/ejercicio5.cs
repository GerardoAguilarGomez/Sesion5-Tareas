using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio5
    {
        public void Binario(int n)
        {
            int num = n;
            string resultado = "";
            int resto;

            while (n > 1)
            {

                resto = n % 2;
                n = n / 2;

                resultado = string.Concat(resto, resultado);


            }
            resultado = string.Concat(1, resultado);

            Console.WriteLine("La representación binaria del número {0} es {1}",num,resultado);

        }
    }
}
