using BackEndCompany.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackEndCompany.Data
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comment", "testSchema");
            builder.Property(e => e.Id).HasColumnName("commentid");
            builder.Property(e => e.CompanyId).HasColumnName("companyid");
            builder.Property(e => e.Text).HasColumnName("commenttext");
            builder.HasOne(d => d.Company)
            .WithMany(p => p.Comments)
            .HasForeignKey(d => d.CompanyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("comments_companyid_fkey");
        }
    }
}
