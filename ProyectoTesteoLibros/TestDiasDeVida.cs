using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestDiasDeVida
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testeo1año1mes1dia() //años,meses,dias,diasDeVida;
        {
            int calculo = ProgramEjercicios.CalcularDiasDeVida(1, 1, 1);
            Assert.That(calculo, Is.EqualTo(396));

        }

       

        [Test]
        public void Test2año2mes2dias() //años,meses,dias,diasDeVida;
        {
            int calculo = ProgramEjercicios.CalcularDiasDeVida(2, 2, 2);
            Assert.That(calculo, Is.EqualTo(792));

        }
    }

    }

