using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Xolartek.Entities;

namespace Xolartek.Data
{
    public class XolarDatabase : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialCost> MaterialCosts { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Schematic> Schematics { get; set; }
        public DbSet<Trait> Traits { get; set; }
        public DbSet<TraitImpact> TraitImpacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MaterialEFConfig());
            modelBuilder.Configurations.Add(new TraitEFConfig());
            modelBuilder.Configurations.Add(new SchematicEFConfig());

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Schematic>()
            //    .HasOptional(s => s.Picture);
            //modelBuilder.Entity<Material>()
            //    .HasOptional(m => m.Picture);
        }
    }
}
