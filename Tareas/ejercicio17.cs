using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio17
    {
        public void Array17()
        {
            string[] lista = new string[10];

            Rellenar(lista);

            Visualizar(lista);
        }

        public string[] Rellenar(string[] lis)
        {
            for(int i = 0; i <= lis.Length - 1; i++)
            {
                Console.WriteLine("Inserta valor para la posición {0}: ", i);
                lis[i] = Console.ReadLine();
            }

            return lis;
        }

        public void Visualizar(string[] lis)
        {
            for(int i = 0; i <= lis.Length - 1; i++)
            {
                Console.WriteLine(lis[i]);
            }
        }
    }
}
