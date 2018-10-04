using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////
            // PROGRAMA PRINCIPAL //
            ////////////////////////
            menu();

            ///////////////
            // FUNCIONES //
            ///////////////

            /// 1. CREO LA FUNCION MENU ///
            void menu()
            {
                Console.WriteLine(" -------------------------");
                Console.WriteLine(" -  PROGRAMA DE PEDIDOS  -");
                Console.WriteLine(" -------------------------");
                Console.WriteLine("");
                Console.WriteLine(" 1. VER MENU DE EMPANADAS");
                Console.WriteLine(" 2. ZONAS DE ENTREGA");
                Console.WriteLine(" 3. HACER PEDIDO");
                Console.WriteLine(" 4. PROMOCIONES");
                Console.WriteLine(" 5. SALIR");
                Console.WriteLine("");

                Console.Write(" Ingrese Una Opción: ");
                int opcionSwitch = 0;
                opcionSwitch = Convert.ToInt32(Console.ReadLine());

                switch (opcionSwitch)
                {
                    case 1:
                        Linea();
                        MenuEmpandas();
                        Linea();
                        menu();
                        break;

                    case 2:
                        Console.WriteLine("Ingresaste opción 2. ZONAS DE ENTREGA");
                        menu();
                        break;

                    case 3:
                        Console.WriteLine("Ingresaste opción 3. HACER PEDIDO");
                        menu();
                        break;

                    case 4:
                        Console.WriteLine("Ingresaste opción 4. PROMOCIONES");
                        menu();
                        break;

                    case 5:
                        salir();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opción Inválida. Vuelva a ingresar una Opción.");
                        Console.WriteLine("");
                        menu();
                        break;
                }
            }

            /// 2. CREO LA FUNCION LIMPIAR PANTALLA
            void LimpiarPantalla()
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine("");
                }
            }

            /// 3. CREO LA FUNCION LINEA (Que sirve para dejar una línea en blanco y un decorado)
            void Linea()
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("");
            }

            /// FUNCION OPCION 1. VER MENU DE EMPANADAS
            void MenuEmpandas()
            {
                Console.WriteLine("   MENU DE EMPANADAS   ");
                Console.WriteLine("- Jamón y queso");
                Console.WriteLine("- Carne");
                Console.WriteLine("- Pollo");
                Console.WriteLine("- Caprese");
                Console.WriteLine("- Verdura");
                Console.WriteLine("- Queso y Cebolla");
            }

            /// FUNCION OPCION 2. ZONAS DE ENTREGA
            /// ACA SE PROGRAMARA LA FUNCION PARA ZONAS DE ENTREGA

            /// FUNCION OPCION 3. HACER PEDIDO
            /// ACA SE PROGRAMARA LA FUNCION PARA HACER PEDIDO

            /// FUNCION OPCION 4. PROMOCIONES
            /// ACA SE PROGRAMARA LA FUNCION PARA PROMOCIONES

            /// FUNCION OPCION 5. SALIR
            void salir()
            {
                Linea();
                Console.WriteLine("Muchas gracias! Hasta luego.");
                Linea();
                Environment.Exit(0);
            }
        }
    }
}
