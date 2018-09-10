using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPresentes
{
    class Program
    {
        static void Main(string[] args)
        {
            double clases;
            double asistencia;
            
            Console.Write("Ingrese Cantidad de Clases: ");
            clases = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese Asistencia: ");
            asistencia = Convert.ToInt32(Console.ReadLine());

            if (asistencia / clases < 0.75){
                Console.WriteLine("Quedaste libre.");
            }
            else
            {
                Console.WriteLine("Sos alumno regular.");
            }

        }
    }
}
