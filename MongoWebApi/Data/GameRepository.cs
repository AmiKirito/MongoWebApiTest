using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoWebApi.Interfaces;
using MongoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoWebApi.Data
{
    public class GameRepository : IGameRepository
    {
        private readonly GamestoreContext _context = null;

        public GameRepository(IOptions<Settings> settings)
        {
            _context = new GamestoreContext(settings);
        }

        public async Task<ICollection<Game>> GetAll()
        {
            try
            {
                return await _context.Games.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}
