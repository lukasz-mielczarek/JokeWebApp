using JokeWebApp.Map;
using JokeWebApp.Models;
using System.Collections.Generic;
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
            if (await _jokeRepository.GetById(jokeModel.Id.ToString()) == null)
            {
                await _jokeRepository.AddAsync(Mapper.ToEntity(jokeModel));
            }

        }

    }
}
