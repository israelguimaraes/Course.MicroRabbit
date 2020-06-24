using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly IEventBus _bus;

        //public TransferEventHandler(IEventBus bus)
        //{
        //    _bus = bus;
        //}

        public TransferEventHandler()
        {

        }

        public Task Handle(TransferCreatedEvent @event)
        {


            return Task.CompletedTask;
        }
    }
}
