using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E103.EntityFramework;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        ////#pragma warning disable IDE0058 // Expression value is never used
        builder.Property(user => user.Id).IsRequired();
        ////#pragma warning restore IDE0058 // Expression value is never used

        // Alternative
        _ = builder.Property(user => user.FullName).IsRequired().HasMaxLength(100);
    }
}
