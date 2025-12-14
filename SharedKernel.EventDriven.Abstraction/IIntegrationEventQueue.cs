using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedKernel.EventDriven.Abstraction;
using SharedKernel.MessageBus.Abstraction;

namespace SharedKernel.EventDriven
{
    public interface IIntegrationEventQueue:IIntegrationEventProducer
    {
        public IEnumerable<IntegrationEvent> GetAllEvents();
    }
}
