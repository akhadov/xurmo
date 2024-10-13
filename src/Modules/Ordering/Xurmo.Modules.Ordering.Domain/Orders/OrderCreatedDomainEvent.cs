using Xurmo.Common.Domain;

namespace Xurmo.Modules.Ordering.Domain.Orders;
public sealed class OrderCreatedDomainEvent(Guid orderId) : DomainEvent
{
    public Guid OrderId { get; init; } = orderId;
}

