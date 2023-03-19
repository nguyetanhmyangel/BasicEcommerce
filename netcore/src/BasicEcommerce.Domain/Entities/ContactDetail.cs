using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class ContactDetail : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? Address { get; set; }
    public double? Lat { get; set; }
    public double? Lng { get; set; }
    public Active Active { get; set; }
}