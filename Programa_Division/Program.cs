using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;

            Console.WriteLine("Se necesitan dos numeros para realizar la division");

            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la division es: " + resultado);
            Console.ReadKey();
        }
    }
}
