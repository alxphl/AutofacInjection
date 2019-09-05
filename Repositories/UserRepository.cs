using System.Collections.Generic;
using autofacInjection.Interfaces;
using autofacInjection.Models;
using MongoDB.Driver;

namespace autofacInjection.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoDatabase _mongoDatabase;
        public UserRepository(IMongoDatabase mongoDatabase)
        {
            _mongoDatabase = mongoDatabase;
        }
        public List<User> GetUsers()
        {
            return _mongoDatabase.GetCollection<User>("Users").Find(x => x.Name == "Alex").ToList();
        }
    }
}
