using System;
/*22)Se necesita ingresar una fecha en formato DDMMAAAA dos dígitos para el día, 
 * dos dígitos para el mes y cuatro dígitos para el año. Si pide informar si DD y MM 
 * son correctos o si son incorrectos. Utilizar una prueba booleana para informar el resultado.
 * (variable booleana puede tomar los valores true o false).
 a. Ej. Fecha válida: 31122013 
 b. Ej. Fecha inválida: 12312013
 c. Ej. Fecha inválida: 29022015
*/
namespace Ejercicio22
{
    class Ej22
    {
        static void Main(string[] args)
        {
            //declarar variables
            int fecha = 0 , dia = 0, mes = 0, anio = 0;
            bool valida = true;

            //pedir que ingresen las fechas
            Console.WriteLine("ingrese fecha");
            fecha = int.Parse(Console.ReadLine());

                        
            //desglosamos la fecha
            anio = fecha / 100000;
            mes = (fecha % 1000000) / 10000;
            dia = fecha / 1000000;

            //validamos fecha
            if ((dia >= 1 || dia <= 31) && (mes >= 1 || mes <= 12) && (anio > 0))
            {
                switch (mes)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia <= 30)
                        {
                            valida = true;
                        }
                        else
                        {
                            valida = false;
                        }
                        break;

                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia <= 31)
                        {
                            valida = true;
                        }
                        else
                        {
                            valida = false;
                        }
                        break;

                    case 2:
                        if (anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0))
                        {
                            if (dia <= 29)
                            {
                                valida = true;
                            }
                            else
                            {
                                valida = false;
                            }
                        }
                        else
                        {
                            if (dia <= 28)
                            {
                                valida = true;
                            }
                            else
                            {
                                valida = false;
                            }
                        }
                        break;

                }
            }
            else
            {
                valida = false;
            }

            if (valida)
            {
                Console.WriteLine($"la fecha {dia}/{mes}/{anio} es valida");
            }
            else
            {
                Console.WriteLine($"la fecha {dia}/{mes}/{anio} es invalida");
            }

        }
    }
}
