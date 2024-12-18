using EventBus.Base.Events;

namespace EventBus.Base.Abstraction
{
    public interface IEventBus
    {
        void Publish(IntegrationEvent @event);
        void Subscrib<T, TH>() where T:IntegrationEvent where TH : IIntegrationEventHandler<T>;
    }
}
