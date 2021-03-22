using JokeWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JokeWebApp.Services
{
    public interface IJokeService
    {

        Task SaveJokeToDatabase(JokeModel jokeModel);
        Task<List<JokeModel>> GetJokesFromDatabase();
    }
}
