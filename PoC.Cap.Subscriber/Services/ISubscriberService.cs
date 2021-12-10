using System;

namespace PoC.Cap.Subscriber.Services
{
    public interface ISubscriberService
    {
        void CheckReceivedMessage(object payload);
    }
}
