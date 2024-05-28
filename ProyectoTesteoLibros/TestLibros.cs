using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            LibrosRepository librosRepository= new LibrosRepository();
            Assert.Pass();
        }
    }
}