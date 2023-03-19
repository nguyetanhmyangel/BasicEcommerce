using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Language : AuditableEntity<Guid>
{
    public required string Code { get; set; }
    public required string DisplayName { get; set; }
    public Active Active { get; set; }

    public virtual ICollection<ProductTranslation> ProductTranslations { set; get; } = null!;
}