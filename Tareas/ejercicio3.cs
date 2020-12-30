using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio3
    {
        public void Primos()
        {

            Console.WriteLine("Indique que número quiere comprobar si es primo: ");
            string n = Console.ReadLine();
            int Num = Convert.ToInt32(n);

            int contador = 0;

            for (int i = 1; i <= Num; i++)
            {

                if (Num % i == 0)
                {

                    contador++;

                }

            }

            if (contador == 2)
            {

                Console.WriteLine("Es primo");

            }
            else
            {
                Console.WriteLine("No es primo");
            }

        }
    }
}
