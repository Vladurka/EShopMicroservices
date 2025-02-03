namespace Ordering.Domain.Events.Orders;

public record OrderCreatedEvent(Order order) : IDomainEvent;