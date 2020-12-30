using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio10
    {
        public void TablaMultiplicar()
        {
            Console.WriteLine("Indica el número del que quieres mostrar la tabla de multiplicar:");
            string n = Console.ReadLine();
            int Num = Convert.ToInt32(n);

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}", Num, i, Num * i);
            }
        }
    }
}
