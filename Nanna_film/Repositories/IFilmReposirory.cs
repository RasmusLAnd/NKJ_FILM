using Nanna_film.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Nanna_film.Repositories
{
    public interface IFilmRepository
    {
        Film [] GetAllFilmsAsync();
        Film GetFilmAsync(int id);
        Film GetFilmByName(string name);

       // Film GetFilmByStudioId(int studioId);

        Film AddFilm(Film film);
    }
}
