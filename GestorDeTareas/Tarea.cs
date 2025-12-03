using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeTareas
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }    
        public DateTime FechaAlta { get; set; }


        //construc, cada vez q se cree una tarea
        public Tarea(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;

            Completada = false; //por defecto false, no está completada
            FechaAlta = DateTime.Now; //momento en q se crea la tarea   
        }

        //override para imprimir el estado

        public override string ToString()
        {
            //operador ?  true : false
            string estado = Completada ? "[X]" : "[ ]";
            return $"{estado} {Titulo} - (Creada: {FechaAlta.ToShortDateString()}";
        }
    }
}
