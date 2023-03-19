using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class AnnouncementUser : AuditableEntity<Guid>
{
    public Guid AnnouncementId { get; set; }
    public bool? HasRead { get; set; }

    public virtual Announcement Announcement { get; set; }
}