using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    public class SmsMessageSender: MessageSender
    {
        public SmsMessageSender(string from, string to): base(from, to) { }

        public override IMessage Send(string text)
        {
            return new SmsMessage();
        }
    }
}
