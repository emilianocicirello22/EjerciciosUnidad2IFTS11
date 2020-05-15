using System;
/*13) Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor  o si son iguales.*/
namespace Ejercicio13
{
    class Ej13
    {
        static void Main(string[] args)
        {
            //declarar variables
            int fecha1 = 0, fecha2 = 0, dia1 = 0, dia2 = 0, mes1 = 0, mes2 = 0, anio1 = 0, anio2 = 0;
            string r1 = "", r2 = "";

            //pedir que ingresen las fechas
            Console.WriteLine("ingrese primer fecha");
            fecha1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segunda fecha");
            fecha2 = int.Parse(Console.ReadLine());

            //precargamos las respuestas para no repetir mucho codigo
            r1 = $"la primer fecha ({fecha1}) es menor a la segunda ({fecha2})";
            r2 = $"la segunda fecha ({fecha2}) es menor a la primera ({fecha1})";

            //desglosamos el año
            anio1 = fecha1 % 100000;
            anio2 = fecha2 % 100000;
            Console.WriteLine(anio1);

            //consultamos si el año 1 es menor al 2
            if(anio1 < anio2)
            {
                //mostrramos respuesta
                Console.WriteLine(r1);
            }
            else
            {
                //preguntamos si el año 2 es menor al 1
                if(anio2 < anio1)
                {
                    //mostrramos respuesta
                    Console.WriteLine(r2);
                }
                else
                {
                    //calculamos el mes
                    mes1 = (fecha1 % 1000000) / 10000;
                    mes2 = (fecha2 % 1000000) / 10000;

                    //preguntamos si el mes 1 es menor al 2
                    if (mes1 < mes2)
                    {
                        //mostrramos respuesta
                        Console.WriteLine(r1);
                    }
                    else
                    {
                        //preguntamos si el mes 2 es mas chico que el mes 1
                        if (mes2 < mes1)
                        {
                            //mostrramos respuesta
                            Console.WriteLine(r2);
                        }
                        else
                        {
                            //calculamos el dia
                            dia1 = fecha1 / 1000000;
                            dia2 = fecha2 / 1000000;

                            //preguntamos si el dia 1 es mas chico que el 2
                            if (dia1 < dia2)
                            {
                                Console.WriteLine(r1);
                            }
                            else
                            {
                                //preguntamos si el dia 2 es mas chico que el 1
                                if (dia2 < dia1)
                                {
                                    //mostramos respuesta
                                    Console.WriteLine(r2);
                                }
                                else
                                {
                                    Console.WriteLine($"las fechas son iguales {fecha1} == {fecha2}");
                                }
                            }
                        }
                    }
                }

            }

        }
    }
}
