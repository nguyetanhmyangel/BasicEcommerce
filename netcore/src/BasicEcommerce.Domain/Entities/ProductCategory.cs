using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class ProductCategory : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public Guid? ParentId { get; set; }
    public int? HomeOrder { get; set; }
    public string? ImagePath { get; set; }
    public bool? HomeFlag { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public int SortOrder { get; set; }
    public Active Active { get; set; }
    public string? SeoPageTitle { get; set; }
    public string? SeoAlias { get; set; }
    public string? SeoKeywords { get; set; }
    public string? SeoDescription { get; set; }
}