using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public abstract class MessageSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public MessageSender(string from, string to)
        {
            From = from;
            To = to;
        }
        abstract public IMessage Send(string text);
    }
}
