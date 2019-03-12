using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetSeed.Domain
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
