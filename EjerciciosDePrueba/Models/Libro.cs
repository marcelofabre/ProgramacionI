using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Models
{
    public class Libro
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        
            public string _id { get; set; }
            public string nombre { get; set; }
            public string paginas { get; set; }
            public string autor { get; set; }
            public string portada_url { get; set; }
     


    }
}
