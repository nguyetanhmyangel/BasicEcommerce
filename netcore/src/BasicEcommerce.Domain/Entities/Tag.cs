using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class Tag : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Type { get; set; }
        
    public virtual ICollection<PostTag> PostTags { set; get; } = null!;
}