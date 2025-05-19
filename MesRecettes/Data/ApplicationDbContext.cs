using MesRecettes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MesRecettes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recette> Recettes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IngredientRecette> IngredientRecettes { get; set; }
        public DbSet<OrigineAliment> OrigineAliments { get; set; }
        public DbSet<TypeAliment> TypeAliments { get; set; }
        public DbSet<UniteDeMesure> UniteDeMesures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IngredientRecette>()
                .HasKey(ir => new { ir.RecetteId, ir.IngredientId });

            modelBuilder.Entity<Recette>()
                .HasOne(r => r.TypeAliment)
                .WithMany()
                .HasForeignKey(r => r.TypeAlimentId);

            modelBuilder.Entity<Recette>()
                .HasOne(r => r.OrigineAliment)
                .WithMany()
                .HasForeignKey(r => r.OrigineAlimentId);

            modelBuilder.Entity<Recette>()
                .HasMany(r => r.RecetteIngredients)
                .WithOne(ri => ri.Recette)
                .HasForeignKey(ri => ri.RecetteId);


            modelBuilder.Entity<Ingredient>()
                .HasMany(i => i.IngredientRecettes)
                .WithOne(ri => ri.Ingredient)
                .HasForeignKey(ri => ri.IngredientId);

            modelBuilder.Entity<Ingredient>()
                .HasOne(i => i.UniteDeMesure)
                .WithMany()
                .HasForeignKey(i => i.UniteDeMesureId);
        }

    }

}