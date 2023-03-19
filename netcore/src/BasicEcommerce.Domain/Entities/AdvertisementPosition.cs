using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class AdvertisementPosition : AuditableEntity<Guid>
{
    public Guid AdvertisementPageId { get; set; }
    public required string Name { get; set; }
    public Active Active { get; set; }

    public virtual AdvertisementPage AdvertisementPage { get; set; } 
    public virtual ICollection<Advertisement> Advertisements { set; get; } = null!;
}