using Microsoft.AspNetCore.Mvc;
using System;

namespace PoC.Cap.Subscriber2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriberController : ControllerBase
    {
        [HttpGet("CheckReceivedMessage2")]
        public void CheckReceivedMessage(object payload)
        {
            Console.WriteLine(payload);
        }
    }
}
