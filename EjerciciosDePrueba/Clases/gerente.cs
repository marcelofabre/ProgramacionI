using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class gerente : empleado
    {

        public gerente(String nombre, String apellido) : base(nombre,apellido)
        {

        }

        public override string ImprimirDatos()
        {
            return "Gerente: fyhndmjy ng    |                                                                                                                                                                                                                                                                                                                                                                                                                                                               " + base.ImprimirDatos();
        }

    }

}


