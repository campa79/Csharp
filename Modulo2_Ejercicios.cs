using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosModulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarea 2: Crea un programa que diga el resultado de sumar 200 y 56.*/
            int resultado = 200 + 56;
            Console.WriteLine(resultado);

            /* Tarea 3: Haz un programa que calcule el producto de los números 13 y 12. */
            int multiplicacion = 13 * 12;
            Console.WriteLine(multiplicacion);

            /* Tarea 4: Un programa que calcule la diferencia(resta) entre 321 y 213 */
            int resta = 321 - 213;
            Console.WriteLine(resta);

            /* Tarea 5: Calcular el resultado de(20 + 5) % 6 */
            resultado = (20 + 5) / 6;
            Console.WriteLine(resultado);

            /* Tarea 6: Crea un programa que calcule el producto de los números 12 y 102, usando variables. */
            int var1 = 12;
            int var2 = 102;

            resultado = var1 * var2;
            Console.WriteLine("El resultado es " + resultado);

            /* Tarea 7: Crea un programa que calcule la suma de 200 y 1111, usando variables. */

            /* Tarea 8: Crea un programa que calcule el producto de los números 10 y 25, usando variables 
             * llamadas "numero1" y "numero2".  */

            /* Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el usuario. */
            Console.Write("Introduzca Primer Número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca Segundo Número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La multiplicación da " + num1 * num2);

            /* Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par
             * (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos 
             * es cero: if (x % 2 == 0) …). */


            /* Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos. */


            /* Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará 
             * el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, 
             * escribirá "Error: No se puede dividir entre cero". */

            /* Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de 
             * ese número, usando "switch"(por ejemplo, si introduce "1", el programa escribirá "uno").
            

            /* Tarea 14: Crea un programa que escriba en pantalla los números del 1 al 10, usando "while" */


            /* Tarea 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while". */


            /* Tarea 16: Crea un programa que muestre los números del 10 al 20, ambos incluidos, 
             * usando “for” */
        }
    }
}
