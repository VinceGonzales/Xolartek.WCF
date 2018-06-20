using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Xolartek.Entities;

namespace Xolartek.Domain
{
    public class MaterialEFConfig : EntityTypeConfiguration<Material>
    {
        public MaterialEFConfig()
        {
            ToTable("Materials");
            HasKey<int>(s => s.Id)
                .Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            HasMany<MaterialCost>(m => m.MaterialCosts)
                .WithRequired(mc => mc.Material)
                .HasForeignKey(mc => mc.MaterialId)
                .WillCascadeOnDelete(false);

            HasOptional(m => m.Picture);
        }
    }
}
