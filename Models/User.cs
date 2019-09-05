using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace autofacInjection.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Token { get; set; }
        public DateTime TokenExpiresAt { get; set; }
        public User(string name, string passwordHash)
        {
            Name = name;
          
            PasswordHash = passwordHash;
            Token = null;
        }
    }
}
