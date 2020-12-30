using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio9
    {
        public void Array9()
        {
            string[] lista = new string[5];

            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine("Inserte valor para la posición {0}", i);
                lista[i] = Console.ReadLine();

            }



            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine(lista[i]);
            }


        }
    }
}
