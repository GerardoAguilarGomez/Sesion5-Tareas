using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class seleccionar
    {
        public void SeleccionarEjercicio()
        {
            Console.WriteLine("Selecciona el ejercicio que deseeas");
            string n = Console.ReadLine();
            int Num_Ejer = Convert.ToInt32(n);

            switch (Num_Ejer)
            {
                case 1:
                    ejercicio1 ejer = new ejercicio1();
                    ejer.ElegirFigura();
                    break;
                case 2:
                    ejercicio2 ejer2 = new ejercicio2();
                    ejer2.Aleatorios();
                    break;
                case 3:
                    ejercicio3 ejer3 = new ejercicio3();
                    ejer3.Primos();
                    break;
                case 4:
                    Console.WriteLine("Introduzca el número del que desea calcular el factorial: ");
                    string numero_factorial = Console.ReadLine();
                    int Num = Convert.ToInt32(numero_factorial);
                    ejercicio4 ejer4 = new ejercicio4();
                    ejer4.Factorial(Num);
                    break;

                case 5:
                    Console.WriteLine("Introduzca el número del que desea calcular el binario: ");
                    string numero_binario = Console.ReadLine();
                    int Num_ejer5 = Convert.ToInt32(numero_binario);
                    ejercicio5 ejer5 = new ejercicio5();
                    ejer5.Binario(Num_ejer5);
                    break;
                case 6:
                    ejercicio6 ejer6 = new ejercicio6();
                    ejer6.Numero_Cifras();
                    break;
                case 7:
                    ejercicio7 ejer7 = new ejercicio7();
                    ejer7.Conversor();
                    break;
                case 8:
                    ejercicio8 ejer8 = new ejercicio8();
                    ejer8.Array8();
                    break;
                default:

                    break;
            }
        }
    }
}
