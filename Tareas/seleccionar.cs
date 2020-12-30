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
                default:

                    break;
            }
        }
    }
}
