using System;
//15) Se leen dos números y se necesita informarlos en orden ascendente.
namespace Ejercicio15
{
    class Ej15
    {
        static void Main(string[] args)
        {
            //declaramos variables
            double n1 = 0, n2 = 0;

            //pedimos que ingresen datos
            Console.WriteLine("Ingrese primer numero");
            n1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese segundo numero");
            n2 = double.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                Console.WriteLine($"{n1} ---> {n2}");
            }
            else
            {
                if (n2 < n1)
                {
                    Console.WriteLine($"{n2} ---> {n1}");
                }
                else
                {
                    Console.WriteLine($"{n1} <===> {n2}");
                }
            }
        }
    }
}
