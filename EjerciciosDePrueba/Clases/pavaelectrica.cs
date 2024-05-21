using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosDePrueba.Clases
{
    internal class PavaElectrica
    {
        // Campos privados
        private string color;
        private string marca;
        private int temperaturaMaxima;
       

        // Propiedades públicas
        public int Temperatura;
        public string Modo;
        public bool encendido;
        public string tipoBebida;

        // Constructor
        public PavaElectrica(string color, string marca, int temperaturaMaxima)
        {
            this.color = color;
            this.marca = marca;
            this.temperaturaMaxima = temperaturaMaxima;
            this.Temperatura = 26; // Temperatura inicial
            this.Modo = "Hervir agua"; // Modo por defecto
            this.encendido = false; // La pava se inicializa apagada
            this.tipoBebida = "Té"; // Tipo de bebida por defecto
        }

        
        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }

      

        public void SeleccionarTipoBebida(string tipoBebida)
        {
            if (this.encendido)
            {
                this.tipoBebida = tipoBebida;
            }
            else 
            {
                Console.WriteLine("Error: la pava eléctrica debe estar encendida.");
            }
        }

        public void CalentarAgua()
        {
            if (this.encendido)
            {
                // Establecer la temperatura q queremos según el tipo de bebida elegido
                int temperaturaObjetivo=0;

                if (tipoBebida == "TE"|| tipoBebida == "TÉ" || tipoBebida == "té"|| tipoBebida == "te")
                {
                    temperaturaObjetivo = 60;
                }
                else if (tipoBebida == "Mate"|| tipoBebida == "MATE"|| tipoBebida == "mate")
                {
                    temperaturaObjetivo = 100;
                    
                }
                else
                {
                    
                    Console.WriteLine("Error: tipo de bebida no valida.");
                    
                }



                // Calentar el agua hasta alcanzar la temperatura objetivo
                while (Temperatura < temperaturaObjetivo)
                {
                    //mientras la temperatura sea menor a temperatura objetivo, mostrar q el agua se esta calentando y los grados en el que essta
                    Temperatura++;
                    Console.WriteLine("Calentando agua, Temperatura: " + Temperatura + "°C");
                }

                // Apagar automáticamente al alcanzar la temperatura objetivo
                Console.WriteLine("El agua ya esta lista.");
                this.encendido = false;
            }

            else
            {
                Console.WriteLine("Error: la pava eléctrica debe estar prendida para calentar agua.");
            }
        }
    }
}
