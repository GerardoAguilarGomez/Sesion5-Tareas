using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio16
    {
        public void Capicua()
        {
            int[] lista = new int[5];
            Console.WriteLine("Array de 5 posiciones");
            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine("Introduce valor entero para casilla nº {0}", i);
                string valor = Console.ReadLine();
                int Valor = Convert.ToInt32(valor);
                lista[i] = Valor;
            }

            bool comprobar = true;

            for(int i = 0; i <= lista.Length/2; i++)
            {
                if (lista[i] != lista[lista.Length - i - 1])
                {
                    comprobar=false;
                }
            }
            
            if (comprobar == true)
            {
                Console.WriteLine("Si que es capicua");
            }
            else
            {
                Console.WriteLine("No es capicua");
            }
        }
    }
}
