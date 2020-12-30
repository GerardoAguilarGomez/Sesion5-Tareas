using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio11
    {
public void Array11()
        {
            int resultado = 0;
            int[] lista = new int[10];
            for (int i = 0; i <= lista.Length-1; i++)
            {
                Console.WriteLine("Introduce valor entero para casilla nº {0}", i);
                string valor = Console.ReadLine();
                int Valor = Convert.ToInt32(valor);
                lista[i] = Valor;

                resultado = resultado + lista[i];

            }

            Console.WriteLine("El resultado de sumar todos los valores es {0}", resultado);
        }
    }
}
