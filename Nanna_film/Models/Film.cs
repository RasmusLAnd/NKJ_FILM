using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nanna_film.Models
{
    public class Film
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int NumberOfFilms { get; set; }
            public int NumberInStudios { get; set; }

            public IEnumerable<Studio> Studios { get; internal set; }
      
    }
}

