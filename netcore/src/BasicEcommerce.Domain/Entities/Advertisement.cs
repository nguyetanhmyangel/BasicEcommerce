using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities;

public class Advertisement : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public string? Url { get; set; }
    public Guid AdvertisementPositionId { get; set; }
    public Active Active { get; set; }
    public int SortOrder { get; set; }

    public virtual AdvertisementPosition AdvertisementPosition { get; set; } = null!;
}