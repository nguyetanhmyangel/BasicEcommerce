using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Function : AuditableEntity<Guid>
{
    public string? Name { get; set; }
    public string? Url { get; set; }
    public Guid? ParentId { get; set; }
    public int SortOrder { get; set; } = default;
    public string? Icon { get; set; }
    public Active Active { get; set; }
}