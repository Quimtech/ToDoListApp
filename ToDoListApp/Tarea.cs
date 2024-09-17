using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class Tarea
    {
        // Propiedades de la tarea
        public string Descripcion { get; set; }
        public DateTime? FechaLimite { get; set; }
        public bool EstaCompleta { get; set; }

        // Constructor de la tarea
        public Tarea(string descripcion, DateTime? fechaLimite = null)
        {
            Descripcion = descripcion;
            FechaLimite = fechaLimite;
            EstaCompleta = false;
        }

        // Metodo para mostrar la tarea
        public override string ToString()
        {
            string fechaLimiteString = FechaLimite.HasValue ? FechaLimite.Value.ToShortDateString() : "Sin Fecha Límite";
            string estado = EstaCompleta ? "Completada" : "Pendiente";
            return $"{Descripcion} - Fecha Límite: {fechaLimiteString} - Estado: {estado}";
        }
    }
}

