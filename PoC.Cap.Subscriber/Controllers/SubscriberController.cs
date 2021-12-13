﻿using Microsoft.AspNetCore.Mvc;
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

