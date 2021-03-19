using JokeWebApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Models
{
    public interface IJokeRepository
    {
        Task AddAsync(Joke joke);
        Task<List<Joke>> GetAllAsync();
        Task<Joke> GetById(string id);
    }
}
