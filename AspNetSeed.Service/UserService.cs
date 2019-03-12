using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetSeed.Domain;

namespace AspNetSeed.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<User> GetUsers()
        {
            return _repository.GetAll();
        }
    }
}
