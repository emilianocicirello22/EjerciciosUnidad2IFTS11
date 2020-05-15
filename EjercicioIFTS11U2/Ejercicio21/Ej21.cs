using System;
/*21)Ingresar un número entero de cuatro dígitos que representa un año. 
    Se pide indicar si fue, es,  o será bisiesto.Un año es bisiesto si es divisible por 400 ó, 
    si es divisible por 4 pero no por 100.*/
namespace Ejercicio21
{
    class Ej21
    {
        static void Main(string[] args)
        {
            //declaramos variables
            int anio = 0;

            //pedimos que ingrese un año
            Console.WriteLine("Ingrese un año");
            anio = int.Parse(Console.ReadLine());

            //preguntamos si el año es biciesto

            if (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine($"El año {anio} es biciesto");
            }
            else
            {
                Console.WriteLine($"El año {anio} no es biciesto");
            }
        }
    }
}
