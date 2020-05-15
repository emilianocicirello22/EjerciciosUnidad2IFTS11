using System;
/*18) Se leen tres datos que representan el apellido, sueldo básico y antigüedad de un empleado. 
 Se debe informar el nombre y el sueldo a cobrar. El sueldo se calcula adicionando al sueldo 
 básico el 40% del mismo si la antigüedad supera los 9 años.*/
namespace Ejercicio18
{
    class Ej18
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            string apellido = "";
            double Sbasico = 0;
            int antiguedad = 0;

            //pedimos que ingresen los datos
            Console.WriteLine("Ingrese apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese antiguedad");
            antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sueldo basico");
            Sbasico = double.Parse(Console.ReadLine());

            //calculamos el sueldo

            if (antiguedad > 9)
            {
                
                Sbasico= (double)Sbasico * 1.40;
                Console.WriteLine($"El sueldo que debe cobrar {apellido} es de ${Sbasico}");
            }
            else
            {
                Console.WriteLine($"El sueldo que debe cobrar {apellido} es de ${Sbasico}");
            }
        }
    }
}
