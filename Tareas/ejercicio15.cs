using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio15
    {
        public void InvertirArray()
        {
            int resultado = 0;
            int[] lista = new int[10];
            int[] lista_invertida = new int[10];
            for (int i = 0; i <= lista.Length - 1; i++)
            {
                Console.WriteLine("Introduce valor entero para casilla nº {0}", i);
                string valor = Console.ReadLine();
                int Valor = Convert.ToInt32(valor);
                lista[i] = Valor;

                resultado = resultado + lista[i];

            }

            int contador = 0;

            for(int i = lista.Length - 1; i >= 0; i--)
            {
                lista_invertida[contador] = lista[i];
                contador++;
            }

            Console.WriteLine("Array invertida:");

            foreach (int i in lista_invertida)
            {
                Console.WriteLine(i);
            }
        }
    }
}
