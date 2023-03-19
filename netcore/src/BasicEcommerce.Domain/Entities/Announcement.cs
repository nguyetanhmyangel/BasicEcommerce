using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Announcement : AuditableEntity<Guid>
{
    public required string Title { get; set; }
    public string? Content { get; set; }
    public Active Status { get; set; } 
    
    public virtual ICollection<AnnouncementUser> AnnouncementUsers { set; get; }
}