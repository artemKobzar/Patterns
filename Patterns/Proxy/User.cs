using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public override string ToString()
        {
            return string.Format($"Name:{Name}; Password:{Password}");
        }
    }
}
