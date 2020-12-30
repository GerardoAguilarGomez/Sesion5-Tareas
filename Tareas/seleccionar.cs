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
                case 9:
                    ejercicio9 ejer9= new ejercicio9();
                    ejer9.Array9();
                    break;
                case 10:
                    ejercicio10 ejer10 = new ejercicio10();
                    ejer10.TablaMultiplicar();
                    break;
                case 11:
                    ejercicio11 ejer11 = new ejercicio11();
                    ejer11.Array11();
                    break;
                case 12:
                    ejercicio12 ejer12 = new ejercicio12();
                    ejer12.Array12();
                    break;
                case 13:
                    ejercicio13 ejer13 = new ejercicio13();
                    ejer13.Array13();
                    break;
                case 14:
                    ejercicio14 ejer14 = new ejercicio14();
                    ejer14.Array14();
                    break;
                case 15:
                    ejercicio15 ejer15 = new ejercicio15();
                    ejer15.InvertirArray();
                    break;
                case 16:
                    ejercicio16 ejer16 = new ejercicio16();
                    ejer16.Capicua();
                    break;
                case 17:
                    ejercicio17 ejer17 = new ejercicio17();
                    ejer17.Array17();
                    break;
                case 18:
                    ejercicio18 ejer18= new ejercicio18();
                    ejer18.Array18();
                    break;
                case 19:
                    ejercicio19 ejer19 = new ejercicio19();
                    ejer19.Array19();
                    break;
                default:

                    break;
            }
        }
    }
}
