using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    abstract class empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        protected empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public virtual string ImprimirDatos()
        {
            return $" {Apellido} {Nombre}";


        }
    }


}
