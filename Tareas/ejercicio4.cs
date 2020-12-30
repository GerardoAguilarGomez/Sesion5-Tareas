using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio4
    {
        public void Factorial(int N)
        {

            int Total = N;

            for (int i = N - 1; i >= 1; i--)
            {

                Total = Total * i;

            }

            Console.WriteLine("El factorial de {0} es {1}", N, Total);

        }
    }
}
