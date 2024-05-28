using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepository
    {
        string urlApi = "https://tomibiblioteca-813c.restdb.io/rest/biblioisp20?";
        HttpClient client = new HttpClient();

        public LibrosRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70c68885459910bfe7e");
        }

        public async Task<ObservableCollection<Libro>> ObtenerLibrosAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);

        }
    }
}
