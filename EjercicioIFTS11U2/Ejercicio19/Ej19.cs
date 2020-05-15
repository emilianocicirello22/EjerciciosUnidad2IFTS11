using System;
/*19)Diseñar un algoritmo que realice la consistencia de una fecha, es decir que los tres datos leídos 
    (día, mes, año) correspondan a una fecha válida. Informando si la fecha es correcta, o bien informando 
    la primer parte  inconsistente.Ej Fecha válida: 31 12 2013 Ej Fecha inválida: 12 31 2013.*/

    //IMPORTANTE ESTE EJERCICIO SOLO VALIDA LOS RANGOS, Y FORMATO DE LA FECHA
namespace Ejercicio19
{
    class Ej19
    {
        static void Main(string[] args)
        {
            //declaramos variables
            int dia = 0, mes = 0, anio = 0;

            //pedimos que ingrese dia / mes / año
            Console.WriteLine("Ingrese dia");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese mes");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año");
            anio = int.Parse(Console.ReadLine());

            if (anio < 1)
            {
                Console.WriteLine($"el año {anio} es incorrecto");
            }
            else
            {
                if(mes<1 || mes > 12)
                {
                    Console.WriteLine($"el mes {mes} es incorrecto");
                }
                else
                {
                    if (dia < 1 || dia > 31) 
                    {
                        Console.WriteLine($"el dia {dia} es incorrecto");
                    }
                    else
                    {
                        Console.WriteLine($"La fecha es valida");
                    }
                }
            }
        }
    }
}
