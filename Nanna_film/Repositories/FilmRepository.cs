using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Nanna_film.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Films { get; set; }

        //public Studio[] {get;set;}

        public Film[] GetAllFilmsAsync()
        {
            Film[] Films = {
                new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberInStudios = 2  },

                new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberInStudios = 2 },

                new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberInStudios = 1 },
            };

            return Films;
        }

        public Film GetFilmAsync(int id)
        {
            if (id == 1)
            {
                return new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberInStudios = 3 };
            }
            else if (id == 2)
            {
                return new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberInStudios = 2 };
            }
            else if (id == 3)
            {
                return new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberInStudios = 1 };
            }
            else
            {
                throw new Exception("Failure in GetFilmAsync");
            }
        }

        public Film GetFilmByName(string name)
        {
            if (name == "Film1")
            {
                return new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberInStudios = 3 };
            }
            else if (name == "Film2")
            {
                return new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberInStudios = 2 };
            }
            else if (name == "Film3")
            {
                return new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberInStudios = 1 };
            }
            else
            {
                throw new Exception("Failure in GetFilmAsync");
            }
        }

        public Film AddFilm(Film film)
        {
            return new Film { Id = 4, Name = "Film4", NumberOfFilms = 30, NumberInStudios = 3 };
        }

        /*public Film GetFilmByStudioIdint (string studioId)
        {
            if (studioId == "Studio1")
            {
                return new Film() { Id = 1, Name = "Film1", NumberOfFilms = 4, NumberInStudios = 3 };
            }
            else if (name == "Film2")
            {
                return new Film() { Id = 2, Name = "Film2", NumberOfFilms = 2, NumberInStudios = 2 };
            }
            else if (name == "Film3")
            {
                return new Film() { Id = 3, Name = "Film3", NumberOfFilms = 5, NumberInStudios = 1 };
            }
            else
            {
                throw new Exception("Failure in GetFilmAsync");
            }
        }*/

    }
}
