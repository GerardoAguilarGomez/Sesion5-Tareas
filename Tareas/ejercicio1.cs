using System;
using System.Collections.Generic;
using System.Text;

namespace Tareas
{
    class ejercicio1
    {
        public void ElegirFigura()
        {
            Console.WriteLine("Selecciona tipo de figura: Circulo - Triangulo - Cuadrado");
            string figura = Console.ReadLine();

            switch (figura)
            {
                case "Circulo":
                    Console.WriteLine("El área del círculo es {0}",CalcularCirculo());
                    break;

                case "Triangulo":
                    Console.WriteLine("El área del triangulo es {0}", CalcularTriangulo());
                    break;
                case "Cuadrado":
                    Console.WriteLine("El área del cuadrado es {0}", CalcularCuadrado());
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        public double CalcularCirculo()
        {
            Console.WriteLine("Indica el radio del círculo: ");
            string r = Console.ReadLine();
            double radio = Convert.ToDouble(r);

            return radio * radio * Math.PI;
        }

        public double CalcularTriangulo()
        {
            Console.WriteLine("Indica la base del triangulo: ");
            string b = Console.ReadLine();
            double Base = Convert.ToDouble(b);

            Console.WriteLine("Indica la altura del triangulo: ");
            string a = Console.ReadLine();
            double Altura = Convert.ToDouble(a);

            return Base * Altura / 2;
        }

        public double CalcularCuadrado()
        {
            Console.WriteLine("Indica el lado del cuadrado: ");
            string l = Console.ReadLine();
            double Lado = Convert.ToDouble(l);

            return Lado * Lado;
        }

    }
}
