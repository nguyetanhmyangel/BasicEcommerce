using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Product : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public Guid ProductCategoryId { get; set; }
    public Guid ProductTagId { get; set; }
    public string? Barcode { get; set; }
    public string? ImagePath{ get; set; }
    public string? Description { get; set; }
    public decimal Rate { get; set; }
    public decimal Price { get; set; }
    public decimal? PromotionPrice { get; set; }
    public decimal OriginalPrice { get; set; }
    public string? Content { get; set; }
    public bool? HomeFlag { get; set; }
    public bool? HotFlag { get; set; }
    public int? ViewCount { get; set; }
    public string? SeoPageTitle { set; get; }
    public string? SeoAlias { set; get; }
    public string? SeoKeywords { set; get; }
    public string? SeoDescription { set; get; }
    public Active Active { set; get; }
    public Guid BrandId { get; set; }
        
    public virtual Brand Brand { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }
    public virtual ProductTag ProductTag { get; set; }
    public virtual ICollection<BillDetail> BillDetails { set; get; } = null!;
    public virtual ICollection<ProductTranslation> ProductTranslations { set; get; } = null!;
    public virtual ICollection<ProductImage> ProductImages { set; get; } = null!;
}