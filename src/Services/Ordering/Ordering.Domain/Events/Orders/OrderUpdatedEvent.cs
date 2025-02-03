namespace Ordering.Domain.Events.Orders;

public record OrderUpdatedEvent(Order order) : IDomainEvent;