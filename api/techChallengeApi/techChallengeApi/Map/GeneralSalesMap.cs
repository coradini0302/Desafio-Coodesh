using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using techChallengeApi.Model;

namespace techChallengeApi.Map
{
    public class GeneralSalesMap : IEntityTypeConfiguration<GeneralSales>
    {
        public void Configure(EntityTypeBuilder<GeneralSales> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date);
            builder.Property(x => x.Value).HasMaxLength(30);

            builder.HasOne(x => x.Product);
            builder.HasOne(x => x.Seller);
            builder.HasOne(x => x.Variety);




        }
    }
    
}
