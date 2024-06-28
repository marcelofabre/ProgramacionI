using EjerciciosDePrueba.Repositories;
using Newtonsoft.Json;
using System.Text;
using System;
using EjerciciosDePrueba.Models;

namespace ProyectoTesteoLibros
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()

        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libros = await librosRepository.ObtenerLibrosAsync();

            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.AgregarAsync("librotest", "paginastest", "autortest", "portada_urltest");
            Assert.That(libro.nombre, Is.EqualTo("librotest"));
        }

        [Test]
        public async Task TestEliminarLibro()
        {
            LibrosRepository librosRepositorio = new LibrosRepository();
            var borrado = await librosRepositorio.EliminarAsync("665a15f1b384736b000011f6");
            Assert.That(borrado, Is.EqualTo(true));
        }

        [Test]
        public async Task TestObtenerLibro()
        {
            LibrosRepository librosRepositorio = new LibrosRepository();
            var libro = await librosRepositorio.ObtenerPorIdAsync("6576576ab83d2f73000000a2");
            Assert.That(libro.nombre, Is.EqualTo("Sentadilla Libre"));
        }
    }
}