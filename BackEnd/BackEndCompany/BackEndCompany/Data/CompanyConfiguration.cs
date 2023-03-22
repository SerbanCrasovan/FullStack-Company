using BackEndCompany.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace BackEndCompany.Data
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("company", "testSchema");
            builder.Property(e => e.Id).HasColumnName("companyid");
            builder.Property(e => e.Name).HasColumnName("companyname");
            builder.HasMany(d => d.Comments)
            .WithOne(p => p.Company)
            .HasForeignKey(d => d.CompanyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("comments_companyid_fkey");
        }
    }
}
