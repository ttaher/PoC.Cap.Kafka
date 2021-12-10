using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using PoC.Cap.Infrastucture;
using System;

namespace PoC.Cap.Subscriber.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscriberController : ControllerBase
    {
        [HttpGet()]
        public void CheckReceivedMessage(object payload)
        {
            Console.WriteLine(payload);
        }
    }
}

