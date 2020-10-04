using MongoWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoWebApi.Interfaces
{
    public interface IGameRepository
    {
        Task<ICollection<Game>> GetAll();
    }
}
