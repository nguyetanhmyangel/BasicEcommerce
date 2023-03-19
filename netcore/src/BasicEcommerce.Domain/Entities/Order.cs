using BasicEcommerce.Domain.Contracts;
namespace BasicEcommerce.Domain.Entities;

public class Order : AuditableEntity<Guid>
{
    public required string Name { get; set; }
    public DateTime? OrderDate { get; set; }
    public DateTime? RequiredDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public int? ShipVia { get; set; }
    public decimal? Freight { get; set; }
    public string? Address { get; set; }
    public Guid UserId { get; set; }
    public Guid CityId { get; set; }
    public Guid ShipperId { get; set; }
    public string? PostalCode { get; set; }
    
    public virtual Shipper Shipper { get; set; }
    public virtual City City { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { set; get; } = null!;
}