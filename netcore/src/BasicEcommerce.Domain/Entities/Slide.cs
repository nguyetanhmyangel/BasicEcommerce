using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Entities
{
    public class Slide : AuditableEntity<Guid>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? Url { get; set; }
        public int? DisplayOrder { get; set; }
        public Active Active { get; set; }
        public string? Content { get; set; }
        public string? GroupAlias { get; set; }
    }
}