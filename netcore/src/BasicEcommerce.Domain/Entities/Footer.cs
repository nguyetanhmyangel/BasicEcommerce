using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Footer : AuditableEntity<Guid>
{
    public string? Content { get; set; }
}