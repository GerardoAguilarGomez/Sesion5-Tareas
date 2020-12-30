using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio19
    {
        public void Array19()
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
            int max = 0;
            for (int i = 0; i <= lis.Length - 1; i++)
            {

                lis[i] = Aleatorio();
                Console.WriteLine("Posición {0}: {1}", i, lis[i]);
                total = total + lis[i];
                if (lis[i] > max)
                {
                    max = lis[i];
                }
            }

            Console.WriteLine("El valor máximo es {0}", max);

        }
        private int Aleatorio()
        {
            int aleatorio = 0;
            Random Rdn = new Random();

            aleatorio=Rdn.Next(1, 100);

            int contador = 0;

            for (int i = 1; i <= aleatorio; i++)
            {

                if (aleatorio % i == 0)
                {

                    contador++;

                }
            }
            if (contador == 2)
            {

                return aleatorio;

            }
            else
            {
                return Aleatorio();
            }
        }
    }
}
