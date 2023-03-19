using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class PostCategory: AuditableEntity<Guid>
{
    public required string Name { set; get; }
    public string? Alias { set; get; }
    public string? Description { set; get; }
    public int? ParentId { set; get; }
    public int? DisplayOrder { set; get; }
    public string? ImageUrl { set; get; }
    public bool? HomeFlag { set; get; }

    public virtual ICollection<Post> Posts { set; get; } = null!;
}