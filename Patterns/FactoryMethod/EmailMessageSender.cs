using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public class EmailMessageSender: MessageSender
    {
        public EmailMessageSender(string from, string to) : base(from, to) { }

        public override IMessage Send(string text)
        {
            return new EmailMessage();
        }
    }

}
