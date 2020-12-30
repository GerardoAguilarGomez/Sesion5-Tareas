using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio13
    {
        public void Array13()
        {
            Console.WriteLine("Indica la longitud del array");
            string l = Console.ReadLine();
            int Longitud = Convert.ToInt32(l);

            int[] lista = new int[Longitud];

            for(int i = 0; i <= lista.Length - 1; i++)
            {
                Random Rdn = new Random();
          
                lista[i]= Rdn.Next(1, 10);
            }

            for(int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine("Posición {0}: {1}",i,lista[i]);
            }
        }
    }
}
