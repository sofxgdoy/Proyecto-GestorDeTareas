using System;
using System.Collections.Generic; //necesario para listas
namespace GestorDeTareas
{
    internal static class Program
    {

        static List<Tarea> listaTareas = new List<Tarea>(); // donde se almacenan las tareas
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("---Menú del Gestor de Tareas--");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Completar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccionar una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarTarea();
                        break;

                    case "2":
                        ListarTareas();
                        break;
                    case "3":
                        CompletarTarea();
                            break;
                    case "4":
                        Console.WriteLine("Nos Vemos!");
                        continuar = false;
                            break;
                    default:
                        Console.WriteLine("Opcion no disponible");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        //Metodos

        static void AgregarTarea()
        {
            Console.WriteLine("---AGREGAR TAREA NUEVA---");

            Console.Write("Título:  ");
            string titulo = Console.ReadLine();

            Console.Write("Descripcion: ");
            string desc = Console.ReadLine();

            //queda crear el objeto(tarea) y agregarlo a la lista

            Console.WriteLine("TODO: Aquí crearemos la tarea...");

        }

        static void ListarTareas()
        {
            Console.WriteLine("---LISTA DE TAREAS---");
            //completar, recorrer la lista
            Console.WriteLine("TODO: Aquí mostraremos la lista...");

        }

        static void CompletarTarea()
        {
            Console.WriteLine("--- COMPLETAR TAREA ---");
            //  Buscar y actualizar
            Console.WriteLine("TODO: Aquí completaremos tareas...");
        }
    }
}
