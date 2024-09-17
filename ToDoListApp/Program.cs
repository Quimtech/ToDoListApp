using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDeTareas gestorDeTareas = new GestorDeTareas();
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.Clear();
                Console.WriteLine("Aplicación de Lista de Tareas");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Listar Tareas");
                Console.WriteLine("3. Marcar Tarea como Completada");
                Console.WriteLine("4. Eliminar Tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese la descripción de la tarea: ");
                            string descripcion = Console.ReadLine();
                            Console.Write("Ingrese la fecha límite (opcional, formato: dd/MM/yyyy): ");
                            string fechaLimiteInput = Console.ReadLine();
                            DateTime? fechaLimite = string.IsNullOrWhiteSpace(fechaLimiteInput)
                                ? (DateTime?)null
                                : DateTime.ParseExact(fechaLimiteInput, "dd/MM/yyyy", null);
                            gestorDeTareas.AgregarTarea(descripcion, fechaLimite);
                            Console.WriteLine("Tarea agregada con éxito.");
                            break;

                        case 2:
                            Console.WriteLine("Tareas:");
                            gestorDeTareas.ListarTareas();
                            Console.WriteLine("Presione una tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 3:
                            // Mostrar la lista antes de marcar como completada
                            Console.WriteLine("Tareas disponibles para marcar como completadas:");
                            gestorDeTareas.ListarTareas();
                            Console.Write("Ingrese el número de la tarea para marcar como completada: ");
                            int indiceCompletar = int.Parse(Console.ReadLine()) - 1;
                            try
                            {
                                gestorDeTareas.MarcarTareaComoCompleta(indiceCompletar);
                                Console.WriteLine("Tarea marcada como completada.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al marcar la tarea como completada: {ex.Message}");
                            }
                            Console.WriteLine("Presione una tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 4:
                            // Mostrar la lista antes de eliminar
                            Console.WriteLine("Tareas disponibles para eliminar:");
                            gestorDeTareas.ListarTareas();
                            Console.Write("Ingrese el número de la tarea para eliminar: ");
                            int indiceEliminar = int.Parse(Console.ReadLine()) - 1;
                            try
                            {
                                gestorDeTareas.EliminarTarea(indiceEliminar);
                                Console.WriteLine("Tarea eliminada.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error al eliminar la tarea: {ex.Message}");
                            }
                            Console.WriteLine("Presione una tecla para volver al menú...");
                            Console.ReadKey();
                            break;

                        case 5:
                            ejecutando = false;
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Presione una tecla para intentar de nuevo...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error general: {ex.Message}");
                    Console.WriteLine("Presione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}
