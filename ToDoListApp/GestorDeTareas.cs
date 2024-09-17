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
        public bool MarcarTareaComoCompleta(int indice)
        {
            if (indice < 0 || indice >= tareas.Count)
            {
                return false;
            }

            tareas[indice].EstaCompleta = true;
            return true;
        }

        // Metodo para eliminar una tarea
        public bool EliminarTarea(int indice)
        {
            if (indice < 0 || indice >= tareas.Count)
            {
                return false;
            }

            tareas.RemoveAt(indice);
            return true;
        }
    }
}
