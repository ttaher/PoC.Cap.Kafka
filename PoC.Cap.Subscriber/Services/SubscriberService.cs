using DotNetCore.CAP;
using PoC.Cap.Infrastucture;
using System;

namespace PoC.Cap.Subscriber.Services
{
    public class SubscriberService : ISubscriberService, ICapSubscribe
    {
        [CapSubscribe(EventBusKey.EventCreated)]
        public void CheckReceivedMessage(object payload)
        {
            Console.WriteLine(payload);
        }
    }
}
