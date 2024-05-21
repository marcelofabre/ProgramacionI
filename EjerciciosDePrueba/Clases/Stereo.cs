using EjerciciosDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Stereo
    {

        // Campos privados
        private string color;
        private string marca;



        // Propiedades públicas

        public Modostereo modo;
        public bool encendido;
        public string radio;
        public string bluetooth; 
        public string pistaCD;
        public string entradaAuxiliarAudio;



        public Stereo(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
            this.modo = Modostereo.Radio;
        }




        public void presionarBotonEncendido()
        {
            this.encendido = !this.encendido;
        }

        public void cambiarModo(Modostereo modo)
        {
            if (this.encendido)

                this.modo = modo;

            else Console.WriteLine("error: el stereo debe estar prendido");


        }

        public void SetNombreRadio(string nombreRadio)

        {
            if (modo == Modostereo.Radio)
            {
                radio = nombreRadio;
            }
            else
            {
                Console.WriteLine("No se puede elegir la emisora xq no esta en radio.");
            }

         
        }

        public void SetNombreCancionBluetooth(string nombreCancion)
        {
            if (modo==Modostereo.Bluetooth)
            {
                bluetooth = nombreCancion;
            }
            else
            {
                Console.WriteLine("No se puede elegir la cancion xq no esta en bluetooth.");
            }
        }

        public void SetPistaCD(string pistadeCd)
        {
            if (modo == Modostereo.Cd)
            {
                pistaCD = pistadeCd;
            }
            else
            {
                Console.WriteLine("No se puede elegir la canción porque no está en CD.");
            }
        }

        public void setEntradaAuxiliarAudio(string entradaAudio)
        {
            if (modo == Modostereo.EntradaAuxiliarAudio)
            {
                entradaAuxiliarAudio = entradaAudio;
            }
            else
            {
                Console.WriteLine("No se puede elegir la canción porque no está en Auxiliar.");
            }
        }

        public void Display()
        {
            Console.WriteLine("**************************");
            Console.WriteLine($"Encendido: {encendido}");
            Console.WriteLine($"Modo: {modo}");

            if (encendido)
            {
                if (modo == Modostereo.EntradaAuxiliarAudio)
                {
                    Console.WriteLine($"Escuchando: {entradaAuxiliarAudio}");
                }

                if (modo == Modostereo.Radio)
                {
                    Console.WriteLine($"Escuchando: {radio}");
                }

                if (modo == Modostereo.Cd)
                {
                    Console.WriteLine($"Escuchando: {pistaCD}");
                }

                if (modo == Modostereo.Bluetooth)
                {
                    Console.WriteLine($"Escuchando: {bluetooth}");
                }

                
            }
            else
            {
                Console.WriteLine("El stereo está apagado.");
            }
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();
        }

    }



}
