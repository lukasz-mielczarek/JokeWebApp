using JokeWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JokeWebApp.JokeApi
{
    public static class GetRandomJoke
    {
        public static async Task<JokeModel> GetJoke()
        {
            using var client = new HttpClient();
            var url = "https://v2.jokeapi.dev/joke/Programming?type=single";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            var response = await client.GetAsync(url);
            string json;
            using (var content = response.Content)
            {
                if (response.IsSuccessStatusCode)
                {
                    json = await content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            return JsonConvert.DeserializeObject<JokeModel>(json);
        }
        
    }
}
