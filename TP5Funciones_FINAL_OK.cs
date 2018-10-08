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
            
            /// INICIALIZO VARIABLES "GLOBALES" ///
            int cantidadEmpanadas = 0;
            int totalPagar = 0;
            int jamonYQueso = 0; int carne = 0; int pollo = 0; int verdura = 0; int quesoYCebolla = 0;
            double promo1 = 0; double promo2 = 0; double promo3 = 0; double promo4 = 0;

            SetConsola();
            Menu();

            ///////////////
            // FUNCIONES //
            ///////////////

            /// 0. CREO SETEO INICIAL DE CONSOLA ///
            void SetConsola()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Title = "TP - Ejercicio 5 Funciones";
            }

            /// 1. CREO LA FUNCION MENU ///
            void Menu()
            {
                Console.WriteLine(" ------------------------- ");
                Console.WriteLine(" -  PROGRAMA DE PEDIDOS  - ");
                Console.WriteLine(" ------------------------- ");
                Console.WriteLine("");
                Console.WriteLine(" 1. VER MENU DE EMPANADAS  ");
                Console.WriteLine(" 2. HACER PEDIDO           ");
                Console.WriteLine(" 3. PROMOCIONES            ");
                Console.WriteLine(" 4. SALIR                  ");
                Console.WriteLine("");

                Console.Write(" Ingrese Una Opción: ");
                int opcionSwitch = 0;
                opcionSwitch = Convert.ToInt32(Console.ReadLine());

                switch (opcionSwitch)
                {
                    case 1:
                        Linea();
                        MenuEmpandas();
                        Menu();
                        break;

                    case 2:
                        Linea();
                        Console.WriteLine("--- HACER PEDIDO ---");
                        Linea();
                        HacerPedido();
                        Menu();
                        break;

                    case 3:
                        Linea();
                        Promociones();
                        Menu();
                        break;

                    case 4:
                        Salir();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opción Inválida. Vuelva a ingresar una Opción.");
                        Console.WriteLine("");
                        Menu();
                        break;
                }
            }

            /// 2. CREO LA FUNCION LIMPIAR PANTALLA
            void LimpiarPantalla()
            {
                for(int i = 0; i < 10; i++)
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
                Console.WriteLine("--- MENU DE EMPANADAS ---");
                Console.WriteLine("- JAMON Y QUESO - $20");
                Console.WriteLine("- CARNE - $20");
                Console.WriteLine("- POLLO - $20");
                Console.WriteLine("- VERDURA - $20");
                Console.WriteLine("- QUESO Y CEBOLLA - $20");
                Linea();
            }

            /// FUNCION OPCION 2. HACER PEDIDO
            void HacerPedido()
            {
                Console.Write(" INGRESA TU NOMBRE: ");
                string nombre;
                nombre = Convert.ToString(Console.ReadLine());

                Linea();
                Console.WriteLine(" INGRESA CANTIDAD DE EMPANADAS: ");

                Console.Write(" JAMON Y QUESO: ");
                jamonYQueso = Convert.ToInt32(Console.ReadLine());
                cantidadEmpanadas = jamonYQueso + cantidadEmpanadas;

                Console.Write(" CARNE: ");
                carne = Convert.ToInt32(Console.ReadLine());
                cantidadEmpanadas = carne + cantidadEmpanadas;

                Console.Write(" POLLO: ");
                pollo = Convert.ToInt32(Console.ReadLine());
                cantidadEmpanadas = pollo + cantidadEmpanadas;

                Console.Write(" VERDURA: ");
                verdura = Convert.ToInt32(Console.ReadLine());
                cantidadEmpanadas = verdura + cantidadEmpanadas;

                Console.Write(" QUESO Y CEBOLLA: ");
                quesoYCebolla = Convert.ToInt32(Console.ReadLine());
                cantidadEmpanadas = quesoYCebolla + cantidadEmpanadas;
                Linea();

                Console.WriteLine(nombre + ", pediste " + cantidadEmpanadas + " empanadas.");
                totalPagar = cantidadEmpanadas * 20;
                Console.WriteLine("TOTAL A PAGAR $" + totalPagar);

                Linea();
                Promociones();
            }

            /// FUNCION OPCION 3. PROMOCIONES
            void Promociones()
            {
                Console.WriteLine(" --- INGRESA TU CODIGO DE PROMOCION ---");
                Linea();
                Console.WriteLine(" 1. PERSONAL 2x1: 50% DESCUENTO");
                Console.WriteLine(" 2. CLUB LA NACION: 20% DESCUENTO");
                Console.WriteLine(" 3. CLARIN 365: 10% DESCUENTO");
                Console.WriteLine(" 4. ALUMNO IFTS 18: 35% DESCUENTO");
                Console.WriteLine(" 5. VOLVER AL MENU PRINCIPAL");
                Console.WriteLine("");

                Console.Write(" INGRESE UNA OPCION: ");
                int opcionPromo = 0;
                opcionPromo = Convert.ToInt32(Console.ReadLine());

                switch (opcionPromo)
                {
                    case 1:
                        promo1 = totalPagar * 0.5;
                        Console.WriteLine("");
                        Console.WriteLine("EXCELENTE!, CON EL DESCUENTO PERSONAL 2x1 TOTAL A PAGAR $" + promo1);
                        Linea();
                        break;

                    case 2:
                        promo2 = totalPagar * 0.8;
                        Console.WriteLine("");
                        Console.WriteLine("EXCELENTE!, CON EL DESCUENTO CLUB LA NACION, TOTAL A PAGAR $" + promo2);
                        Linea();
                        break;

                    case 3:
                        promo3 = totalPagar * 0.9;
                        Console.WriteLine("");
                        Console.WriteLine("EXCELENTE!, CON EL DESCUENTO CLARIN 365, TOTAL A PAGAR $" + promo3);
                        Linea();
                        break;

                    case 4:
                        promo4 = totalPagar * 0.65;
                        Console.WriteLine("");
                        Console.WriteLine("EXCELENTE!, CON EL DESCUENTO ALUMNOS IFTS 18, TOTAL A PAGAR $" + promo4);
                        Linea();
                        break;

                    case 5:
                        Menu();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Opción Inválida. Vuelva a ingresar una Opción.");
                        Console.WriteLine("");
                        Menu();
                        break;
                }
            }

            /// FUNCION OPCION 4. SALIR
            void Salir()
            {
                Linea();
                Console.WriteLine("Muchas gracias! Hasta luego.");
                Linea();
                Environment.Exit(0);
            }
        }
    }
}
