using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionU3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controlVersiones = new ControlVersiones();
            bool actualizar, formato, validar, publicar, salir = false;
            string opc = "", seleccion;

            controlVersiones.AñadirVersion("Primera versión del documento", false, false, false, false);

            do
            {
                actualizar = false; formato = false; validar = false; publicar = false; seleccion = " ";
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n=====================================================");
                    Console.WriteLine("                  MENU PRINCIPAL");
                    Console.WriteLine("=====================================================");
                    controlVersiones.MostrarListaNombres();

                    Console.WriteLine($"\n\nSeleccione todas las opciones que desea realizar: {seleccion}");
                    Console.WriteLine("1. Ver todos los proyectos");
                    Console.WriteLine("\n2. Actualizar proyecto");
                    Console.WriteLine("3. Aplicar formato a proyecto");
                    Console.WriteLine("4. Validar proyecto");
                    Console.WriteLine("5. Publicar proyecto");
                    Console.WriteLine("6. Terminar y aplicar la seleccion");
                    Console.WriteLine("0. Salir");
                    Console.Write("Seleccione la opcion a realizar: ");
                    opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "1":
                            Console.Clear();
                            controlVersiones.MostrarListaProyectos();
                            Console.WriteLine("\nPresione cualqueir boton para continuar...");
                            Console.ReadKey();
                            break;
                        case "2":
                            actualizar = true;
                            seleccion = seleccion + "2 ";
                            break;
                        case "3":
                            formato = true;
                            seleccion = seleccion + "3 ";
                            break;
                        case "4":
                            validar = true;
                            seleccion = seleccion + "4 ";
                            break;
                        case "5":
                            publicar = true;
                            controlVersiones.VersionParaPublicar();
                            seleccion = seleccion + "5 ";
                            break;
                        case "6":
                            controlVersiones.AñadirVersion("Lorem Ipsum", validar, formato, publicar, actualizar);
                            break;
                        
                        case "0":
                            Console.WriteLine("Saliendo...");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Esa opcion no es valida.");
                            break;
                    }
                } while (opc != "0" && opc != "6");
            } while (!salir);
        }     
    }
}
