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
                default:

                    break;
            }
        }
    }
}
