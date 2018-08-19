using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosModulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tarea 1: Crea un programa que pida al usuario su identificador y su contraseña(ambos numéricos),
             * y no le permita seguir hasta que introduzca como identificador "1234" y como contraseña "1111". */
            int usuario; int password;

            do
            {
                Console.Write("Ingrese usuario: ");
                usuario = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese contraseña: ");
                password = Convert.ToInt32(Console.ReadLine());

                if (usuario != 1234 && password != 1111)
                    Console.WriteLine("Usuario y/o Password Incorrecto.");
            }
            while (usuario != 1234 || password != 1111);

                Console.WriteLine("Bienvenido al sistema.");

            /* Tarea 2: Crea un programa calcule cuantas cifras tiene un número entero positivo
             * (pista: se puede hacer dividiendo varias veces entre 10). */

            /* Tarea 3: Crea un programa que muestre la tabla de multiplicar del 9. */
            Console.WriteLine("Tabla del 9");
            for (int i = 1; i < 11 ; i++){
                Console.WriteLine("9 x " + i + " = " + 9 * i);
            }

            /* Tarea 4: Crea un programa que contenga un bucle sin fin que muestre los números enteros 
             * positivos a partir del uno. */

            int f = 0; //1 para activar, 0 para desactivar el programa
            while (f != 0) {
                Console.WriteLine(f);
                f++;
            }

            /* Tarea 5: Crea un programa que contenga un bucle sin fin que escriba "Hola " en pantalla, 
             * sin avanzar de línea. */
            int g = 0; //1 para activar, 0 para desactivar el programa
            while (g != 0)
            {
                Console.Write("Hola ");
                g++;
            }

            /* Tarea 6: ¿Cuál sería el resultado de las siguientes operaciones? 
             * a = 5; b = ++a; c = a++; b = b * 5; a = a * 2; Crea un programa que lo resuelva. */

            /* Tarea 7: ¿Cuál sería el resultado de las siguientes operaciones?
             * a = 5; b = a + 2; b -= 3; c = -3; c *= 2; ++c; a *= b; Crea un programa que te lo muestre. */

            /* Tarea 8: Crea un programa que pida una letra al usuario y diga si se trata de una vocal. */
            Console.WriteLine("-- Programa para adivinar vocales ---");

            
            Console.Write("Ingrese una letra: ");
            string letra = Convert.ToString(Console.ReadLine());

                if ("aeiouAEIOU".Contains(letra))
            {
                Console.WriteLine("La " + letra + " es una vocal.");
            }else
                Console.WriteLine("La " + letra + " es una consonante.");

            /* Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. 
             * La contraseña se debe introducir dos veces.Si las dos contraseñas no son iguales,
             * se avisará al usuario y se le volverán a pedir las dos contraseñas. */

            /* Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama 
             * "Martín", o bien le diga "No te conozco" si teclea otro nombre. */
        }
    }
}
