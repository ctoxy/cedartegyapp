using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class AdvConfiguration : IEntityTypeConfiguration<Adv>
    {
        public void Configure(EntityTypeBuilder<Adv> builder)
        {
            builder.Property(a => a.Id).IsRequired();          
            builder.HasOne(t => t.VnRetrofitType).WithMany()
                .HasForeignKey(a => a.VnRetrofitTypeId);
        }
        
    }
}