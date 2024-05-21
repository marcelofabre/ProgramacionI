using EjerciciosDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjerciciosDePrueba.Clases
{
    internal class Split
    {
        //declaramos los campos y propiedades

        //campo: las variables privadas de la clase
        private string color;
        private int frigorias;
        private string marca;
        private bool encendido;

        //propiedades: las variables públicas de la clase
        public int temperatura;
        public ModoEnum modo;

        //constructor: método que se ejecuta cuando la clase se crea, se intancia en memoria, es decir cuando se construye el objeto
        public Split(string pColor, int pFrigorias, string pMarca)
        {
            this.color = pColor;
            this.frigorias = pFrigorias;
            this.marca = pMarca;

            this.temperatura = 24;
            this.modo = ModoEnum.Minimo;
            this.encendido = false;
        }

        public void PresionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }
        public void SubirTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura++;
            }
            else
            {
                Console.WriteLine("Error: El split está apagado");
            }

        }

        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }
            else
            {
                Console.WriteLine("Error: El split está apagado");
            }
        }

        public void CambiarModo(ModoEnum modo)
        {
            if (this.encendido)
                
            this.modo = modo;

            else Console.WriteLine("error: el split debe estar encendido");

        }
    }
}

