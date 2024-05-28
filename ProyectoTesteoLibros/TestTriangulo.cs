using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestTriangulo
    {
        [Test]
        public void TestEquilatero() //años,meses,dias,diasDeVida;
        {
            string Resultado = ProgramEjercicios.CalcularDiasLadosDeUnTriangulosss(1, 1, 1);
            Assert.That(Resultado, Is.EqualTo("Equilatero"));

        }

       
    }
}
