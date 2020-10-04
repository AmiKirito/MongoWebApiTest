using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoWebApi.Interfaces;
using MongoWebApi.Models;
using System.Threading.Tasks;

namespace MongoWebApi.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository noteRepository)
        {
            _gameRepository = noteRepository;
        }

        [Route("/")]
        [Route("/games")]
        [HttpGet]
        public async Task<string> GetGames()
        {
            var games =  await _gameRepository.GetAll();

            return games.ToJson();
        }
    }
}
