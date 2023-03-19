using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities
{
    public class AdvertisementPage : AuditableEntity<string>
    {
        // public AdvertisementPage()
        // {
        //     AdvertisementPositions = new HashSet<AdvertisementPosition>();
        // }

        public required string Name { get; set; }
        public Active Active { get; set; }
    
        public virtual ICollection<AdvertisementPosition> AdvertisementPositions { set; get; } = null!;
    }
}