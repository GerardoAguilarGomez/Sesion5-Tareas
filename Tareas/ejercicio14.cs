using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio14
    {
        public void Array14()
        {
            Console.WriteLine("Indica la longitud del array");
            string l = Console.ReadLine();
            int Longitud = Convert.ToInt32(l);

            int[] lista = new int[Longitud];

            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Random Rdn = new Random();

                lista[i] = Rdn.Next(1, 10);
            }

            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine("Posición {0}: {1}", i, lista[i]);
            }

            Console.WriteLine("Indica que valor quieres buscar: ");
            string b = Console.ReadLine();
            int Buscar = Convert.ToInt32(b);

            bool coincidencia = false;

            for (int i = 0; i <= lista.Length - 1; i++)
            {
                if (lista[i] == Buscar)
                {
                    
                    coincidencia = true;
                    break;
                }
            }

            if (coincidencia == true)
            {
                Console.WriteLine("El número {0} si que está en la lista", Buscar);
            }
            else
            {
                Console.WriteLine("El número {0} no está en la lista", Buscar);
            }
                
            
        }
    }
}
