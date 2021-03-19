using JokeWebApp.Map;
using JokeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Services
{
    public class JokeService : IJokeService
    {
        private readonly IJokeRepository _jokeRepository;
        public JokeService(IJokeRepository jokeRepository)
        {
            _jokeRepository = jokeRepository;
        }
        public async Task<List<JokeModel>> GetJokesFromDatabase()
        {
            var results = await _jokeRepository.GetAllAsync();
            return Mapper.ToModelList(results);
        }

        public async Task SaveJokeToDatabase(JokeModel jokeModel)
        {

            await _jokeRepository.AddAsync(Mapper.ToEntity(jokeModel));
        }

    }
}
