using System.Collections.Generic;
using autofacInjection.Models;

namespace autofacInjection.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
