using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio21
    {
        public void Arrays21()
        {
            Console.WriteLine("Indica el nº de posiciones del array");
            string v = Console.ReadLine();
            int Long = Convert.ToInt32(v);

            int[] lista1 = new int[Long];
            

            Rellenar(lista1);

            Buscar(lista1);
        }

        public void Buscar(int[] lis)
        {
            Console.WriteLine("Muestra los números que acaben en la cifra: ");
            string C = Console.ReadLine();
            int Cifra = Convert.ToInt32(C);

            ArrayList nueva_lista = new ArrayList();

            for(int i = 0; i <= lis.Length - 1; i++)
            {
                int ultima_cifra= (lis[i] % 10);
                if (ultima_cifra == Cifra)
                {
                    nueva_lista.Add(lis[i]);
                }
            }

            for(int i = 0; i <= nueva_lista.Count - 1; i++)
            {
                Console.WriteLine(nueva_lista[i]);
            }
            
        }



        public void Rellenar(int[] lis)
        {

            for (int i = 0; i <= lis.Length - 1; i++)
            {
                lis[i] = Aleatorio();
                //Console.WriteLine("Posición {0}: {1}", i, lis[i]);

            }

        }

        private int Aleatorio()
        {
            Random Rdn = new Random();

            return Rdn.Next(1, 300);
        }
    }
}
