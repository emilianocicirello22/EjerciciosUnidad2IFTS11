using System;
/*11)Dadas las 4 notas obtenidas por un alumno se pide calcular e informar el promedio y una 
 * leyenda que indique si está aprobado. El dato de aprobación se hará a partir de un 
 * valor predeterminado que no podrá ser modificable a lo largo del programa.*/
namespace Ejercicio11
{
    class Ej11
    {
        static void Main(string[] args)
        {
            //declaramos variables
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, prom = 0;
            const int aprobado = 4;

            //pedimos que ingrese las notas
            Console.WriteLine("Ingrese Nota 1");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota 2");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota 3");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota 4");
            nota4 = double.Parse(Console.ReadLine());

            //calculamos el promedio
            prom = (nota1 + nota2 + nota3 + nota4) / 4;

            if(prom >= aprobado)
            {
                Console.WriteLine($"El alumno esta aprobado y su nota es {prom}");
            }
        }
    }
}
