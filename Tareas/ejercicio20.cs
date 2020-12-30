using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio20
    {
        public void Arrays20()
        {
            Console.WriteLine("Indica el nº de posiciones del array");
            string v = Console.ReadLine();
            int Long = Convert.ToInt32(v);

            int[] lista1 = new int[Long];
            int[] lista2 = new int[Long];
            int[] lista_total = new int[Long];

            Rellenar(lista1,lista2);
            lista_total=Multiplicar(lista1, lista2,Long);

            Console.WriteLine("Array 1:");
            for(int i = 0; i <= lista1.Length - 1; i++)
            {
                Console.WriteLine("Posición {0}: {1}", i, lista1[i]);
            }
            Console.WriteLine("Array 2:");
            for (int i = 0; i <= lista2.Length - 1; i++)
            {
                Console.WriteLine("Posición {0}: {1}", i, lista2[i]);
            }

            Console.WriteLine("Array Multi:");
            for (int i = 0; i <= lista_total.Length - 1; i++)
            {
                Console.WriteLine("Posición {0}: {1}", i, lista_total[i]);
            }
        }
        public void Rellenar(int[] lis, int[] lis2)
        {
 
            for (int i = 0; i <= lis.Length - 1; i++)
            {
                lis[i] = Aleatorio();
                lis2[i] = Aleatorio();
                Console.WriteLine("Posición {0}: {1}", i, lis[i]);

            }

        }

       public int[] Multiplicar(int[] lis, int[] lis2,int Long)
        {
            int[] lista_total = new int[Long];
            for(int i = 0; i <= lis.Length - 1; i++)
            {
                lista_total[i] = lis[i] * lis2[i];
            }
            return lista_total;
        }
        private int Aleatorio()
        {
            Random Rdn = new Random();

            return Rdn.Next(1, 10);
        }
    }
}
