using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio8
    {
        public void Array8()
        {
            int[] a = new int[5];

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }


        }
    }
}
