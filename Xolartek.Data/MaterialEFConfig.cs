using System.Data.Entity.ModelConfiguration;
using Xolartek.Entities;

namespace Xolartek.Data
{
    public class MaterialEFConfig : EntityTypeConfiguration<Material>
    {
        public MaterialEFConfig()
        {
            ToTable("Materials");
            HasKey<int>(s => s.Id);

            HasMany<MaterialCost>(m => m.MaterialCosts)
                .WithRequired(mc => mc.Material)
                .HasForeignKey(mc => mc.MaterialId);
        }
    }
}
