using System;
/*20)Se conoce la cantidad total de preguntas realizadas y la cantidad de respuestas correctas de un test de nivel par 
ingresantes a la universidad. Se pide informar el porcentaje de respuestas correctas y una leyenda que indique 
el nivel obtenido según el siguiente criterio:
                                    a.Nivel 1  Porcentaje >=89%
                                    b.Nivel 2  75<=Porcentaje<89
                                    c.Nivel 3  50<=Porcentaje<70
                                    d.Nivel 4  Porcentaje<50
                                    
     */
namespace Ejercicio20
{
    class Ej20
    {
        static void Main(string[] args)
        {
            //declaramos variables
            int preguntas = 0, Pcorrectas = 0;
            double porc = 0;

            //ingresamos datos
            Console.WriteLine("Ingrese total de preguntas contestadas");
            preguntas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese preguntas contestadas correctamente");
            Pcorrectas = int.Parse(Console.ReadLine());

            //calculamos el porcentaje

            porc = (double)(Pcorrectas * 100) / preguntas;

            //averiguamos el nivel segun el porcentaje
            if (porc >= 89)
            {
                Console.WriteLine("Usted es nivel 1");
            }
            else
            {
                if (porc < 89 && porc >= 75)
                {
                    Console.WriteLine("Usted es nivel 2");
                }
                else
                {
                    if (porc < 75 && porc >= 50)
                    {
                        Console.WriteLine("Usted es nivel 3");
                    }
                    else
                    {
                        if (porc < 50)
                        {
                            Console.WriteLine("Usted es nivel 4");
                        }
                    }
                }
            }

            

        }
    }
}
