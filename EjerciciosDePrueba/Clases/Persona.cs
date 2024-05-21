using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Persona
    {
        //declaramos los campos y propiedades
        //campo: las variables privadas de la clase
        private string nombre;
        private string direccion;
        private int año_nac;
        public string Apellido { get; set; }

        private int dni;

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }


        public Persona(string nombre, string direccion, int año_nac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.año_nac = año_nac;
            
        }

        public void decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }



        
    }
}
