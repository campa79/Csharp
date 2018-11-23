// Las System Collections y varios que necesito para correr el programa.
using System;
using System.Collections;

namespace Final_EstructuraDeDatos_IFTS18 // Alumno: Alberto Campagna - Final Estructura de Datos - IFTS 18
                                         // Carrera Analista de Sistemas - 23/11/18
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue miCola = new Queue(); // Creo miCola - Queue
            int opcion; // Opcion Menu 

            //Si el fondo es blanco, invierto los colores para que se vea mejor
            if (Console.BackgroundColor == ConsoleColor.White)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
            }

            do
            {
                Console.Clear(); // Limpia Consola
                opcion = menu(); // Mostrar Menu y Esperar Opción
                switch (opcion)
                {
                    case 1: //Crear Cola
                        crear(ref miCola);
                        break;
                    case 2: //limpiar y vaciar Cola
                        limpiar(ref miCola);
                        break;
                    case 3: //agregar valor a Cola
                        agregar(ref miCola);
                        break;
                    case 4: //borrar útimo elemento de la cola
                        BorrarUltimo(ref miCola);
                        break;
                    case 5: //listar todos los elementos de la cola
                        imprimir(miCola);
                        break;
                    case 6: //listar último elemento de la cola
                        UltimoValor(ref miCola);
                        break;
                    case 7: //listar cantidad de elementos en la cola
                        ListarCantidad(ref miCola);
                        break;
                    case 8: //Acerca de...
                        AcercaDe();
                        break;
                    case 9: //Ayuda
                        Ayuda();
                        break;
                    case 0: break; // Salir del programa con el número 0

                    default:
                        mensaje("ERROR: Ingresá una opción válida.");
                        break;
                }
            }
            while (opcion != 0);
            mensaje("El programa a finalizado.");
        }

        /* CASE 1: Crear Cola ************************************************************************/
        static void crear(ref Queue cola) //Acá es para crear una Cola nueva.
        {
            Queue miCola2 = new Queue();
            Console.WriteLine("\n Mi cola2 creada con éxito.");
            imprimir(cola);
        }

        /** CASE 2: Limpiar y vaciar todos los elementos de la Cola **********************************/
        static void limpiar(ref Queue cola)
        {
            cola.Clear();
            mensaje("La Cola fue vaciada con éxito.");
        }

        /** CASE 3: Agrega un nuevo elemento a la cola ***********************************************/
        static void agregar(ref Queue cola)
        {
            Console.Write("\nIngrese valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine()); // pido ingresar el valor.

                if (valor > 999 || valor < 0) //Paso las condiciones para que el número ingresado sea válido.
                {
                    mensaje("Ingresá números del 1 al 999.");
                }
                else
                {
                    cola.Enqueue(valor);
                    imprimir(cola);
                }
            }
            catch
            {
                mensaje("Error: Ingresar números del 1 al 999.");
            }
        }

        /** CASE 4: Borrar último elemento de la Cola **********************************************/
        static void BorrarUltimo(ref Queue cola)
        {
            try
            {
                int valor = (int)cola.Dequeue();
                Console.WriteLine("\n=====================================");
                Console.WriteLine("Último pedido " + valor + " borrado con éxito.");
                Console.WriteLine("=====================================");
                imprimir(cola);
            }
            catch
            {
                mensaje("Error: La cola está vacía.");
            }
        }

        /** CASE 5: Imprime pila ******************************************************************/
        static void imprimir(Queue cola)
        {
            if (cola.Count != 0)
            {
                Console.WriteLine("");
                foreach (int dato in cola)
                {
                    if (dato < 10)
                        Console.WriteLine(" | 0{0} |", dato);
                    else
                        Console.WriteLine(" | {0} |", dato);
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar ...");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacía.");
            }
        }

        /** CASE 6: Mostrar último valor en la Cola ***********************************************/
        static void UltimoValor(ref Queue cola)
        {
            try
            {
                int valor = (int)cola.Peek();
                Console.WriteLine("\n=====================================");
                Console.WriteLine("El último pedido es " + valor + ".");
                Console.WriteLine("=====================================");
                imprimir(cola);
            }
            catch
            {
                mensaje("Error: La cola está vacía.");
            }
        }

        /** CASE 7: Listar cantidad de valores en la Cola ****************************************/
        static void ListarCantidad(ref Queue cola)
        {
            try
            {
                int valor = (int)cola.Count;
                Console.WriteLine("\n=====================================");
                Console.WriteLine("La cola tiene " + valor + " pedidos.");
                Console.WriteLine("=====================================");
                imprimir(cola);
            }
            catch
            {
                mensaje("Error: La cola está vacía.");
            }
        }

        /** CASE 8: Acerca de... *****************************************************************/
        static void AcercaDe()
        {
                Console.WriteLine("\n=========================================================");
                Console.WriteLine(" Programa hecho para el final de Estructura de Datos");
                Console.WriteLine(" 2do Cuatrimestre de 2018 / Carrera: Analista de Sistemas");
                Console.WriteLine(" Alumno: Alberto Campagna / Fecha: 23/11/18");
                Console.WriteLine("=========================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey(); 
        }

        /** CASE 9: Ayuda ************************************************************************/
        static void Ayuda()
        {
            Console.WriteLine("\n=========================================================");
            Console.WriteLine(" Para usar este programa simplemente navegue a través");
            Console.WriteLine(" de las opciones. Con este programa podrá generar y ");
            Console.WriteLine(" consultar colas, borrar, listar o mostrar.");
            Console.WriteLine("=========================================================");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        /** ANEXO: Elimina elemento de la cola ***************************************************/
        static void eliminar(ref Queue cola)
        {
            if (cola.Count != 0)
             {
                int valor = (int)cola.Dequeue();
                mensaje("Elemento " + valor + " eliminado");
            }
             else {
                imprimir(cola);
            }
        }

        /** MENU DEL PROGRAMA */
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("\n            Pilas, Colas y Listas - Final Estructura de Datos IFTS 18");
            Console.WriteLine("\n            Alumno: Alberto Campagna - TEMA 2 - 13/11/18\n");
            Console.WriteLine("\n");
            Console.WriteLine(" (1) Crear Cola");
            Console.WriteLine(" (2) Borrar Cola");
            Console.WriteLine(" (3) Agregar Pedido");
            Console.WriteLine(" (4) Borrar Último Pedido");
            Console.WriteLine(" (5) Listar Todos los Pedidos");
            Console.WriteLine(" (6) Listar Último Pedido");
            Console.WriteLine(" (7) Ver Cantidad de Pedidos");
            Console.WriteLine(" (8) Acerca de este Programa");
            Console.WriteLine(" (9) Ayuda");
            Console.WriteLine(" (0) Salir del Programa\n");
            Console.Write(" Ingresa tu opción: ");

            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                Console.WriteLine("\r\nERROR: Elegí una opción correcta. Presione una tecla para volver al Menú.\r\n");
                Console.ReadKey();
                return menu();
            }
        }

        /** Funcion que Muestra mensaje  al usuario */
        static void mensaje(String texto)
        {
            if (texto.Length != 0)
             {
                Console.WriteLine("\n=======================================");
                Console.WriteLine(" {0}", texto);
                Console.WriteLine("=======================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
