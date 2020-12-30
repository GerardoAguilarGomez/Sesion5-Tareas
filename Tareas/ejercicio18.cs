using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio18
    {
        public void Array18()
        {
            Console.WriteLine("Indica el nº de posiciones del array");
            string v = Console.ReadLine();
            int Long = Convert.ToInt32(v);
            int[] lista = new int[Long];

            Rellenar(lista);
        }
        public void Rellenar(int[] lis)
        {
            int total = 0;
            for (int i = 0; i <= lis.Length - 1; i++)
            {
                lis[i] = Aleatorio();
                Console.WriteLine("Posición {0}: {1}", i, lis[i]);
                total = total + lis[i];
            }

            Console.WriteLine("La suma de todos los valores es {0}", total);
            
        }
        private int Aleatorio()
        {
            Random Rdn = new Random();

            return Rdn.Next(1, 10);
        }
    }
}
