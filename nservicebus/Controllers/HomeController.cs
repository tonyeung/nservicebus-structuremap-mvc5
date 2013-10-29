using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using NServiceBus;
using messages;

namespace nservicebus.Controllers
{
    public class HomeController : ApiController
    {
    //    private IBus bus;
    //    public HomeController(IBus Bus)
    //    {
    //        bus = Bus;
    //    }

        public string GET()
        {
            var result = "Message Sent";
            //var myMessage = new message() { id = 1 };

            //try
            //{
            //    bus.Send(myMessage);
            //}
            //catch (Exception ex)
            //{

            //    result = ex.Message;
            //}            

            return result;
        }
    }
}
