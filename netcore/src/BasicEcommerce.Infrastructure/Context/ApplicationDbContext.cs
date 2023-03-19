using System.Drawing;
using BasicEcommerce.Application.Interfaces.Services;
using BasicEcommerce.Domain.Contracts;
using BasicEcommerce.Domain.Entities;
using BasicEcommerce.Infrastructure.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BasicEcommerce.Infrastructure.Context;

public class ApplicationDbContext : AuditableContext
{
    private readonly ICurrentUserService _currentUserService;
    private readonly IDateTimeService _dateTimeService;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserService currentUserService, IDateTimeService dateTimeService)
        : base(options)
    {
        _currentUserService = currentUserService;
        _dateTimeService = dateTimeService;
    }
        
    public DbSet<Brand> Brand { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<AdvertisementPage> AdvertisementPages { get; set; }
    public DbSet<AdvertisementPosition> AdvertisementPositions { get; set; }
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<AnnouncementUser> AnnouncementUsers { get; set; }
    public DbSet<BillDetail> BillDetails { get; set; }
    public DbSet<Bill> Bills { get; set; }
    public DbSet<Post> Blogs { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<PostCategory> PostCategories { get; set; }
    public DbSet<ProductColor> Colors { get; set; }
    public DbSet<ContactDetail> ContactDetails { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<FeedBack> FeedBacks { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Function> Menus { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Page> Pages { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<ProductQuantity> ProductQuantities { get; set; }
    public DbSet<ProductTranslation> ProductTranslations { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<ProductSize> Sizes { get; set; }
    public DbSet<Slide> Slides { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<WholePrice> WholePrices { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Continent> Continents { get; set; }
    public DbSet<Footer> Footers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries<IAuditableEntity>().ToList())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedOn = _dateTimeService.NowUtc;
                    entry.Entity.CreatedBy = _currentUserService.UserId;
                    break;

                case EntityState.Modified:
                    entry.Entity.LastModifiedOn = _dateTimeService.NowUtc;
                    entry.Entity.LastModifiedBy = _currentUserService.UserId;
                    break;
            }
        }
        if (_currentUserService.UserId == null)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        else
        {
            return await base.SaveChangesAsync(_currentUserService.UserId, cancellationToken);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        foreach (var property in builder.Model.GetEntityTypes()
                     .SelectMany(t => t.GetProperties())
                     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }
            
        foreach (var property in builder.Model.GetEntityTypes()
                     .SelectMany(t => t.GetProperties())
                     .Where(p => p.Name is "LastModifiedBy" or "CreatedBy"))
        {
            property.SetColumnType("nvarchar(128)");
        }
            
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>(entity =>
        {
            entity.ToTable(name: "Users", "Identity");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        builder.Entity<ApplicationRole>(entity =>
        {
            entity.ToTable(name: "Roles", "Identity");
        });
        builder.Entity<IdentityUserRole<string>>(entity =>
        {
            entity.ToTable("UserRoles", "Identity");
        });

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable("UserClaims", "Identity");
        });

        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.ToTable("UserLogins", "Identity");
        });

        builder.Entity<ApplicationRoleClaim>(entity =>
        {
            entity.ToTable(name: "RoleClaims", "Identity");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.RoleClaims)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        builder.Entity<IdentityUserToken<string>>(entity =>
        {
            entity.ToTable("UserTokens", "Identity");
        });
    }
}