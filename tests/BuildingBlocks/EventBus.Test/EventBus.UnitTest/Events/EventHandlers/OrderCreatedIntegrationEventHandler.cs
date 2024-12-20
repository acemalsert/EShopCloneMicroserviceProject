using EventBus.Base.Abstraction;
using EventBus.UnitTest.Events.Events;

public class OrderCreatedIntegrationEventHandler : IIntegrationEventHandler<OrderCreatedIntegrationEvent>
{
    public Task Handle(OrderCreatedIntegrationEvent @event)
    {
        return Task.CompletedTask;
    }
}