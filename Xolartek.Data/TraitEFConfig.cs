using System.Data.Entity.ModelConfiguration;
using Xolartek.Entities;

namespace Xolartek.Data
{
    public class TraitEFConfig : EntityTypeConfiguration<Trait>
    {
        public TraitEFConfig()
        {
            ToTable("Materials");
            HasKey<int>(s => s.Id);

            HasMany<TraitImpact>(t => t.TraitImpacts)
                .WithRequired(ti => ti.Trait)
                .HasForeignKey(ti => ti.TraitId);
        }
    }
}
