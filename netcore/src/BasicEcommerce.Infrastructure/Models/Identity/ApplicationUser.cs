using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using OfficeOpenXml.FormulaParsing.Utilities;

namespace BasicEcommerce.Infrastructure.Models.Identity;

public class ApplicationUser: IdentityUser<string>, IAuditableEntity<string>
{
    public required string FirstName { set; get; }
    public required string LastName { set; get; }
    public string? Address { set; get; }
    public string? Avatar { get; set; }
    public DateTime? BirthDay { set; get; }
    public Active Active { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
    public string? RefreshToken { get; set; }
    public  DateTime RefreshTokenExpiryTime { get; set; }
}