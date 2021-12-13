using System;

namespace PoC.Cap.Subscriber2.Services
{
    public interface ISubscriberService
    {
        void CheckReceivedMessage(object payload);
    }
}
