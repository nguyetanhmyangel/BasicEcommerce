using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Post : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? ImagePath { get; set; }
    public string? Description { get; set; }
    public string? Content { get; set; }
    public bool? HomeFlag { get; set; }
    public bool? HotFlag { get; set; }
    public int? ViewCount { get; set; }
    public string? Tags { get; set; }
    public Active Active { get; set; }
    public string? SeoPageTitle { get; set; }
    public string? SeoAlias { get; set; }
    public string? SeoKeywords { get; set; }
    public string? SeoDescription { get; set; }
    
    public virtual PostCategory PostCategory { set; get; }
    public virtual ICollection<PostTag> PostTags { set; get; } = null!;
}