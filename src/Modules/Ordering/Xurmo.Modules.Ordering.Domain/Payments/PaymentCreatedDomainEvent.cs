using Xurmo.Common.Domain;

namespace Xurmo.Modules.Ordering.Domain.Payments;
public sealed class PaymentCreatedDomainEvent(Guid paymentId) : DomainEvent
{
    public Guid PaymentId { get; init; } = paymentId;
}

