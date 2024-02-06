using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    public class ClientProxy
    {
        public void UseProxy()
        {
            UserList userList = new UserList();
            userList.Users.Add(new User() { Name = "Tom", Password = "12345" });
            userList.Users.Add(new User() { Name = "Sam", Password = "54321" });
            userList.Users.Add(new User() { Name = "Bob", Password = "67890" });

            IUserRepository userRepository = new UserRepository(userList);
            IUserRepository userRepositoryProxy = new UserRepositoryProxy(userList);

            Console.WriteLine($"Use proxy: {userRepositoryProxy.GetByName("Tom")}");
            Console.WriteLine($"Use repository: {userRepository.GetByName("Tom")}");
            Console.WriteLine($"Use proxy: {userRepositoryProxy.GetByName("Sam")}");
        }     
    }
}
