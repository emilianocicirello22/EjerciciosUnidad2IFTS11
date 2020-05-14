using System;
//17)Ingresar 5 números reales e informar el menor de ellos.
namespace Ejercicio17
{
    class Ej17
    {
        static void Main(string[] args)
        {
            //declaramos variables
            float n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0;

            //pedimos que ingrese los datos
            Console.Write("Ingrese primer numero: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo numero: ");
            n2 = float.Parse(Console.ReadLine());
            
            Console.Write("Ingrese tercer numero: ");
            n3 = float.Parse(Console.ReadLine());
            
            Console.Write("Ingrese cuarto numero: ");
            n4 = float.Parse(Console.ReadLine());
            
            Console.Write("Ingrese quinto numero: ");
            n5 = float.Parse(Console.ReadLine());

            //comparamos los numeros
            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                Console.Write($"el menor es: {n1}");
            }
            else
            {
                if (n2 < n3 && n2 < n4 && n2 < n5)
                {
                    Console.Write($"el menor es: {n2}");
                }
                else
                {
                    if (n3 < n4 && n3 < n5)
                    {
                        Console.Write($"el menor es: {n3}");
                    }
                    else
                    {
                        if (n4 < n5)
                        {
                            Console.Write($"el menor es: {n4}");
                        }
                        else
                        {
                            Console.Write($"el menor es: {n5}");
                        }
                    }
                }
            }
        }
    }
}
