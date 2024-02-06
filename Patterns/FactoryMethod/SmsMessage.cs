using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public class SmsMessage: IMessage
    {
        public SmsMessage() 
        {
            Console.WriteLine("SMS has been sent");
        }
    }
}
