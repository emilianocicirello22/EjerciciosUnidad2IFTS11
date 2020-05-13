using System;
//16)Ingresar 3 números enteros e informar el menor de ellos. CONFECCIONAR PRUEBA DE ESCRITORIO
namespace Ejercicio16
{
    class Ej16
    {
        static void Main(string[] args)
        {
            //declarar variables
            int n1 = 0, n2 = 0, n3 = 0;

            //pedir que ingresen datos
            Console.WriteLine("ingrese primer numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese segundo numero");
            n2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("ingrese tercer numero");
            n3 = int.Parse(Console.ReadLine());

            //Preguntamos por el menor
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"El menor es {n1}");
            }
            else
            {
                if(n2 < n3 && n2 < n1)
                {
                    Console.WriteLine($"El menor es {n2}");
                }
                else
                {
                    Console.WriteLine($"El menor es {n3}");
                }
            }
        }
    }
}
