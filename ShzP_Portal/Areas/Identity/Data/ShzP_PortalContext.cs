using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShzP_Portal.Areas.Identity.Data;

namespace ShzP_Portal.Areas.Identity.Data;

public class ShzP_PortalContext : IdentityDbContext<ShzP_PortalUser>
{
    public ShzP_PortalContext(DbContextOptions<ShzP_PortalContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ShzP_PortalUser>
    {
        public void Configure(EntityTypeBuilder<ShzP_PortalUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.ProfilePicturePath).HasMaxLength(5000);

        }
    }
}
