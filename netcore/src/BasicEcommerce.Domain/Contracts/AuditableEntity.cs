using BasicEcommerce.Domain.Enums;

namespace BasicEcommerce.Domain.Contracts;
using  System;

public abstract class AuditableEntity<TId>: IAuditableEntity<TId>
{
    public required TId Id { get; set; } 
    public string? CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
}