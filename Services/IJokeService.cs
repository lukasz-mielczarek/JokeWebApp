using JokeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Services
{
    public interface IJokeService
    {
        
        Task SaveJokeToDatabase(JokeModel jokeModel);
        Task<List<JokeModel>> GetJokesFromDatabase();
    }
}
