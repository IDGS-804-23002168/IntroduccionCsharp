using Introduccion_csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion_csharp.Services
{
    public class PeliculasServices
    {

        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 120,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)

            };


            var pelicula2 = new Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = 111,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)

            };

            return new List<Pelicula> { pelicula1, pelicula2 };

        }

    }
}