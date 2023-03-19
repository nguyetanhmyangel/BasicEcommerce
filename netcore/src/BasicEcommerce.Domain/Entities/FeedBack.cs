using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class FeedBack : AuditableEntity<Guid>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }
    public Active Active { get; set; }
}