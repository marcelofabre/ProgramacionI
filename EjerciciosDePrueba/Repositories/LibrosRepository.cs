using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

//https://biblioip20-8c17.restdb.io/rest/libros?apikey=d57db9d7572d74af31b5445f5fe19b4f5f007

namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepository//campo 
    {
        string urlApi = "https://biblioip20-8c17.restdb.io/rest/libros?";
        HttpClient client = new HttpClient();

        public LibrosRepository()//constructor metodo que s ellama igual q la clase y no devuelve valores, se ejecuta en el momento en que la clase se instancia en memoria 
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "d57db9d7572d74af31b5445f5fe19b4f5f007");
        }

        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);

        }

        public async Task<Libro?> AgregarAsync( string nombre, string paginas, string autor, string portada_url)
        {

        
            Libro libro = new Libro()
            {
              
                nombre = nombre,
                paginas = paginas,
                autor = autor,
                portada_url = portada_url
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PostAsJsonAsync(urlApi,
                new StringContent(
                     JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json"));
                    


            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());

        }

        public async Task<Libro?> UpdateAsync(string nombre, string autor, string portada_url, string paginas,  string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                autor = autor,
                
                portada_url = portada_url,
              
                paginas = paginas,
                _id=id
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }






     
        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }

        public async Task<Libro?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Libro>(response);
        }

    }


}
