using Microsoft.EntityFrameworkCore;
using PromoCodeAPI.Domain.Entities;

namespace PromoCodeAPI.Infra.Context
{
    public class ContextSqlLite : DbContext
    {
        public ContextSqlLite() { }

        public ContextSqlLite(DbContextOptions<ContextSqlLite> options) : base(options) { }

        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ShoppingCart> Carts  { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            _ = builder.Entity<Movie>()
                     .HasOne(x => x.Cart)
                     .WithOne(c => c.Movie)
                     .HasForeignKey<ShoppingCart>(c => c.MovieId);

            _ = builder.Entity<ShoppingCart>().HasKey(x => x._id);

            _ = builder.Entity<Ticket>()
                     .HasOne(x => x.Cart)
                     .WithMany(x => x.Tickets)
                     .HasForeignKey(x => x.ShoppingCartId);

            _ = builder.Entity<Theatre>()
                    .HasOne(x => x.Cart)
                    .WithOne(x => x.Theatre)
                    .HasForeignKey<ShoppingCart>(c => c.MovieId);
            
            _ = builder.Entity<PromoCode>()
                    .HasOne(m => m.Promotion)
                    .WithMany(m => m.Codes)
                    .HasForeignKey(m => m.PromotionId); 
            
            base.OnModelCreating(builder);

   

            
        }
    }
}
