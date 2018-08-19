using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Ingresa primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if ((n1 >= 1) && (n2 >= 1))
                Console.WriteLine("Ambos números son positivos.");
            else
                Console.WriteLine("Al menos un número no es positivo.");
        }
    }
}
