using MediatR;

namespace Ordering.Core.Abstractions;

public interface IDomainEvent : INotification
{
    public Guid EventId => Guid.NewGuid();
    public DateTime OccuredOn => DateTime.UtcNow;
    public string EventType => GetType().Name;
}