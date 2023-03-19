using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Page : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Alias { get; set; }
    public string? Content { get; set; }
    public Active Active { get; set; } 
}