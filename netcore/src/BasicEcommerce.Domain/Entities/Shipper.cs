using BasicEcommerce.Domain.Contracts;

namespace BasicEcommerce.Domain.Entities
{
    public class Shipper : AuditableEntity<Guid>
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}