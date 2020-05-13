using System;
/*12)Se ingresan dos números enteros  y se pide el resultado de dividirlos, informando el resultado de la división o un mensaje
 * de error si el mismo no se pudo hacer porque uno de los valores no puede ser admitido para la división.*/
namespace Ejercicio12
{
    class Ej12
    {
        static void Main(string[] args)
        {
            //creamos variables
            int dividendo = 0, divisor = 0;

            //pedimos que ingresen datos
            Console.WriteLine("Ingrese dividendo");
            dividendo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese divisor");
            divisor = int.Parse(Console.ReadLine());

            if(divisor == 0)
            {
                Console.WriteLine("El divisor no puede ser 0");
            }
            else
            {
                Console.WriteLine($"El resultado de {dividendo} / {divisor} es {(double)dividendo / divisor}");
            }
        }
    }
}
