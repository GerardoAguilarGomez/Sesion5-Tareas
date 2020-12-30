using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio2
    {
        public void Aleatorios()
        {

            Console.WriteLine("Indica cuantos números aleatorios quieres mostrar");
            string c = Console.ReadLine();
            int Cuantos = Convert.ToInt32(c);


            Console.WriteLine("Indica el valor mínimo");
            string min = Console.ReadLine();
            int Minimo = Convert.ToInt32(min);

            Console.WriteLine("Indica el valor máximo");
            string max = Console.ReadLine();
            int Maximo = Convert.ToInt32(max);



            for (int i = 0; i < Cuantos; i++)
            {

                
                Console.WriteLine(CalculoAleatorio(Minimo, Maximo));
               

            }

        }

        public int CalculoAleatorio(int mi, int ma)
        {
            Random Rdn = new Random();
            return Rdn.Next(mi, ma);

        }
    }
}
