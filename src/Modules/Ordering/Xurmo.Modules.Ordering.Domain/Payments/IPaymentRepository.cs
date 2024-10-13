namespace Xurmo.Modules.Ordering.Domain.Payments;
public interface IPaymentRepository
{
    Task<Payment?> GetAsync(Guid id, CancellationToken cancellationToken = default);

    void Insert(Payment payment);
}
