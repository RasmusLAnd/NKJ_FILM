using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nanna_film.Models;
using Nanna_film.Repositories;
using AutoMapper;

namespace Nanna_film.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IMapper _mapper;

        public FilmsController(IFilmRepository filmRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Film[]> GetAllFilms()
        {
            var result = _filmRepository.GetAllFilmsAsync();
            return result;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Film> GetFilm(int id)
        {
            var result = _filmRepository.GetFilmAsync(id);
            return result;
        }

        [HttpGet("{name}")]
        public ActionResult<Film> GetFilmByName(string name)
        {
            var result = _filmRepository.GetFilmByName(name);
            return result;
        }

        [HttpPost]
        public ActionResult<Film> Post(Film newfilm)
        {
            var film = _mapper.Map<Film>(newfilm);
            _filmRepository.AddFilm(film);
            return Ok();
        }
    }
}
