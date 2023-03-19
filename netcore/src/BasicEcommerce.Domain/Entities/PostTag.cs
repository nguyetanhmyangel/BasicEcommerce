using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities;

public class PostTag : AuditableEntity<Guid>
{
    public Guid TagId { set; get; }
    public Guid PostId { set; get; }
    
    public virtual Post Post { set; get; }
    public virtual Tag Tag { set; get; }
}