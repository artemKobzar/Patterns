using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public class EmailMessage: IMessage
    {
        public EmailMessage()
        {
            Console.WriteLine("Email has been sent");
        }
    }
}
