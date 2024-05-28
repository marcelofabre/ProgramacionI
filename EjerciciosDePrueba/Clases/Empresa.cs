using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    public class Empresa<T> where T : empleado
    {
        List<T> empleados = new List<T>();  
        string nombre;
        public Empresa(string nombre) 

        { 
            this.nombre = nombre; 
        }

        public void agregarEmpleado(T empleado) {
            empleados.Add(empleado);

        }

        public bool quitarEmpleado(T empleado)
        {
            if (empleados.Contains(empleado))
            {
                empleados.Remove(empleado);
                return true;
            }
            else
            {
                return false;
            }
        
        }

        public string ListarPersonas() 
        {
            string retorno =$"Lista de empleados {this.nombre}" + Environment.NewLine;
            foreach (var trabajador in empleados)
            {
                retorno+= trabajador.ImprimirDatos()+Environment.NewLine;
            }
            return retorno;
        }
    }

    
    
}
