using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public interface IUserRepository
    {
        public User GetByName(string name);
        public bool Add(User user);
    }
}
