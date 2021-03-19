using JokeWebApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Models
{
    public class JokeRepository : IJokeRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<Joke> dbSet;

        public JokeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            dbSet = _appDbContext.Set<Joke>();
        }
        public async Task AddAsync(Joke joke)
        {
            await _appDbContext.AddAsync(joke);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Joke>> GetAllAsync()
        {
            var result = await dbSet.ToListAsync();
            return result;
            
        }

        public async Task<Joke> GetById(string id)
        {
            var allJokes = await GetAllAsync();
            return allJokes.Find(x => x.Id == id);
        }
    }
}
