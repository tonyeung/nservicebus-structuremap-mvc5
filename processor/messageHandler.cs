using messages;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processor
{
    public class messageHandler : IHandleMessages<message>
    {
        private IBus bus;
        public messageHandler(IBus Bus)
        {
            bus = Bus;
        }

        public void Handle(message m)
        {
            try
            {
                Console.WriteLine(m.id);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
        }
    }
}
