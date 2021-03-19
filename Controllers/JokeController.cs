using JokeWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JokeWebApp.JokeApi;

namespace JokeWebApp.Controllers
{
    public class JokeController : Controller
    {
        private readonly IJokeService _jokeService;
        public JokeController(IJokeService jokeService)
        {
            _jokeService = jokeService;
        }
        public async Task<IActionResult> GetJokeFromApi()
        {
            var results = await GetRandomJoke.GetJoke();

            await _jokeService.SaveJokeToDatabase(results);
            ViewData["Joke"] = results;
            return View("Admin");
        }
        public async Task<IActionResult> GetAllJokesFromDatabase()
        {
            var results = await _jokeService.GetJokesFromDatabase();
            ViewData["Jokes"] = results;
            return View("JokesList");
        }
    }
}
