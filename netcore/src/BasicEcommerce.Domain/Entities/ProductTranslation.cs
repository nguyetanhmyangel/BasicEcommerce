using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class ProductTranslation: AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public  Guid LanguageId { get; set; }
    public  Guid ProductId { get; set; }
    
    public virtual Language Language { get; set; }
    public virtual Product Product { get; set; }
}