using System;
/*14)Se presentan dos personas en un banco, éste les asigna el primer lugar de la fila a la mayor
 * de ellas,  para lo cual le solicita a cada una de ellas su día, mes y año de nacimiento por separado. 
 * Se solicita informar a cuál de las personas se le asignará el primer lugar de la fila.*/
namespace Ejercicio14
{
    class Ej14
    {
        static void Main(string[] args)
        {
            //declarammos variables
            int dia1 = 0, dia2 = 0,mes1 = 0,mes2 = 0, anio1 = 0, anio2 = 0;
            String r1 = "", r2 = "";

            //pedimos que se ingresen los datos
            Console.WriteLine("Buen dia persona 1\n ingrese su dia de nacimiento");
            dia1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su mes de nacimiento");
            mes1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su año de nacimiento");
            anio1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Buen dia persona 2\n ingrese su dia de nacimiento");
            dia2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su mes de nacimiento");
            mes2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su año de nacimiento");
            anio2 = int.Parse(Console.ReadLine());

            //precargamos respuestas
            r1 = $"el turno es para la persona con fecha de nacimiento {dia1}/{mes1}/{anio1}";
            r2 = $"el turno es para la persona con fecha de nacimiento {dia2}/{mes2}/{anio2}";

            //si el año 1 es menor que el año 2
            if (anio1 < anio2)
            {
                //respuesta
                Console.WriteLine(r1);
            }
            else
            {
                //si el año 2 es menor que el año 1
                if (anio2 < anio1)
                {
                    Console.WriteLine(r2);
                }
                else
                {
                    //si el mes 1 es menor que el mes 2
                    if (mes1 < mes2)
                    {
                        //respuesta
                        Console.WriteLine(r1);
                    }
                    else
                    {
                        //si el mes 2 es menor que el mes 1
                        if (mes2 < mes1)
                        {
                            //respuesta
                            Console.WriteLine(r2);
                        }
                        else
                        {
                            //si el dia 1 es menor que el dia 2
                            if (dia1 < dia2)
                            {
                                //respuesta
                                Console.WriteLine(r1);
                            }
                            else
                            {
                                //si el dia 2 es menor que el dia 1
                                if (dia2 < dia1)
                                {
                                    //respuesta
                                    Console.WriteLine(r1);
                                }
                                else
                                {
                                    /*en caso de que las fechas sean iguales por defecto le dara el turno
                                      a la persona que ingreso los datos primero*/
                                    Console.WriteLine("el turno es para la persona 1");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
