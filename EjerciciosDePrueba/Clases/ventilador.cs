using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class ventilador
    {
        // Campos privados
        private string color;
        private string marca;
        private string tipo;//ventiladores de techo, de pie, de techo industriales, normales 
        private bool encendido;


        // Propiedades públicas
        public int velocidad;
        public string modo;//fijo o automatico

        public ventilador(string color, string marca, string tipo, string modo)
        {
            this.color = color;
            this.marca = marca;
            this.tipo = tipo;
            this.encendido = encendido;
            this.velocidad =0;
            modo = modo;
        }

        public void presionarbotonencendido()
        {
            this.encendido = !this.encendido;
        }


        
        public void subirVelocidad()
        {
            if (this.encendido && velocidad<5)
            {
                velocidad++;
                Console.Write($"se ha subido la temperatura, en este momento esta en la velocidades : {velocidad}");
            }
            else if (this.encendido && velocidad>0)
            {
                velocidad--;
                Console.WriteLine("Error: El ventilador está apagado");
            }            

        }


        public void bajarVelocidad()
        {
            if (this.encendido) 
            {
                velocidad --;
                Console.Write($"se ha bajado la velocidad, en este momento la velocidad es: {velocidad}");
            }
            else
            {
                Console.Write("Error: El ventilador está apagado");
            }
        }

        public void cambiarModo(string modo)
        {
            if(this.encendido)
            {
                this.modo = modo;
                Console.Write($"El modo de ventilador se ha cambiado, el modo es: {modo}");
            }
            else
            {
                Console.Write("Error: el ventilador está apagado");
            }

        }
    }
}
