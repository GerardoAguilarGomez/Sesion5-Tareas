using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio6
    {
        public void Numero_Cifras()
        {

            Console.WriteLine("Introduzca el número del que se desea saber el número de cifras");
            string Num = Console.ReadLine();


            bool saber = validar(Num);
            string contar_numeros = "";


            if (saber == true)
            {
                contar_numeros = Convert.ToString(Num);

                Console.WriteLine("El número de cifras es {0}", contar_numeros.Length);
            }
            else
            {
                Console.WriteLine("Incorrecto, no has insertado un número entero");
            }

        }

        public bool validar(string n)
        {

            try
            {
                int miInt = Convert.ToInt32(n);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;

        }
    }
}
