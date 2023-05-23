using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using techChallengeApi.Model;

namespace techChallengeApi.Map
{
    public class VarietyMap :IEntityTypeConfiguration<Variety>
    {
        public void Configure(EntityTypeBuilder<Variety> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Sort).HasMaxLength(3);
            builder.Property(x => x.Signal).HasMaxLength(3);
            builder.Property(x => x.Kind).HasMaxLength(20);
            builder.Property(x => x.Description).HasMaxLength(50);

        }
    }
}
