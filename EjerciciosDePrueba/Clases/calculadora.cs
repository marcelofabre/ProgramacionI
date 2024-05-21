using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class calculadora
    {
        // Campos privados
        private string color;
        private string marca;
        


        // Propiedades públicas
      
        public string Modo;
        public string tipo;
        public bool encendido;

        public calculadora(string color, string marca, string tipo)
        {
            this.color = color;
            this.marca = marca;
            this.tipo = tipo;
            this.encendido = encendido;
            this.Modo = "basico";
        }





        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }


        public void CambiarModo(string modo)
        {
            if (this.encendido)
            {

                this.Modo = modo;
                Console.Write($"El modo de la calculadora ha cambiado, ahora es: {modo}");

            }
            else
            {
                Console.WriteLine("error: la calculadora tiene  estar encendida:");
            }
        }



        public void Sumar(double num1, double num2, double num3, double num4)
        {
            if (this.encendido)
            {
                double resultado = num1 + num2 + num3 + num4;
                Console.WriteLine($"La suma entre {num1} , {num2}, {num3} y {num4} es: {resultado}");
            }
            else
            {
                Console.WriteLine("La calculadora está apagada. Presiona el botón de encendido.");
            }
        }

        public void Restar(double num1, double num2, double num3, double num4)
        {
            if (this.encendido)
            {
                double resultado = num1 - num2 - num3 - num4;
                Console.WriteLine($"La resta entre {num1} , {num2}, {num3} y {num4} es: {resultado}");
            }
            else
            {
                Console.WriteLine("La calculadora está apagada. Presiona el botón de encendido.");
            }
        }

        public void dividir(double num1, double num2, double num3, double num4)
        {
            if (this.encendido)
            {
                double resultado = num1 / num2 / num3 / num4;
                Console.WriteLine($"La división entre {num1} , {num2}, {num3} y {num4} es: {resultado}");
            }
            else
            {
                Console.WriteLine("La calculadora está apagada. Presiona el botón de encendido.");
            }
        }

        public void multiplicar(double num1, double num2, double num3, double num4)
        {
            if (this.encendido)
            {
                double resultado = num1 * num2 * num3 * num4;
                Console.WriteLine($"La multiplicación entre {num1} , {num2}, {num3} y {num4} es: {resultado}");
            }
            else
            {
                Console.WriteLine("La calculadora está apagada. Presiona el botón de encendido.");
            }
        }

    }
}
