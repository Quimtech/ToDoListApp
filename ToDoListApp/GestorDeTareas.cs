using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class GestorDeTareas
    {
        private List<Tarea> tareas;

        // Constructor que inicia la lista de tareas
        public GestorDeTareas()
        {
            tareas = new List<Tarea>();
        }

        // Metodo para agregar una tarea
        public void AgregarTarea(string descripcion, DateTime? fechaLimite = null)
        {
            tareas.Add(new Tarea(descripcion, fechaLimite));
        }

        // Metodo para listar todas las tareas
        public void ListarTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas disponibles.");
                return;
            }

            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        // Metodo para marcar una tarea como completada
        public void MarcarTareaComoCompleta(int indice)
        {
            if (indice < 0 || indice >= tareas.Count)
            {
                Console.WriteLine("Número de tarea inválido.");
                return;
            }

            tareas[indice].EstaCompleta = true;
        }

        // Metodo para eliminar una tarea
        public void EliminarTarea(int indice)
        {
            if (indice < 0 || indice >= tareas.Count)
            {
                Console.WriteLine("Número de tarea inválido.");
                return;
            }

            tareas.RemoveAt(indice);
        }
    }
}
