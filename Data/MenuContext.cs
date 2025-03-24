using MenuAppBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuAppBlazor.Data
{
    public class MenuContext : DbContext
    {
        //  Specify the generic type for options
        public MenuContext(DbContextOptions<MenuContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });

            modelBuilder.Entity<DishIngredient>()
                .HasOne(d => d.Dish)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(d => d.DishId);

            modelBuilder.Entity<DishIngredient>()
                .HasOne(i => i.Ingredient)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(i => i.IngredientId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; } = default!;
        public DbSet<Ingredient> Ingredients { get; set; } = default!;
        public DbSet<DishIngredient> DishIngredients { get; set; } = default!;
        public DbSet<UpcomingMenuItem> UpcomingMenu { get; set; } = default!;
    }
}
