using Xurmo.Common.Domain;

namespace Xurmo.Modules.Ordering.Domain.Customers;
public static class CustomerErrors
{
    public static Error NotFound(Guid customerId) =>
        Error.NotFound("Customers.NotFound", $"The customer with the identifier {customerId} was not found");
}
