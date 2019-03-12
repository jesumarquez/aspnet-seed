using AspNetSeed.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSeed.Infrastructure
{
    public class MemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public MemoryUserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    Id = 1,
                    Created = DateTime.Now,
                    Modified = DateTime.Now,
                    FirstName = "Pepe",
                    LastName = "Gomez",
                    Email = "pepe@gmail.com"
                }
            };
        }
        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }
}
