using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities
{
    public class ProductSize : AuditableEntity<Guid>
    {
        public string Name { get; set; }
        public virtual ICollection<BillDetail> BillDetails { set; get; }
    }
}