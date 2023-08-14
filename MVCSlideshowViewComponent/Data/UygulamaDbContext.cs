using Microsoft.EntityFrameworkCore;

namespace MVCSlideshowViewComponent.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }

        public DbSet<BilgeSoz> BilgeSozler => Set<BilgeSoz>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BilgeSoz>().HasData(
                new BilgeSoz { Id = 1, Soz = "Yılanı kendi ellerinle öldür", Yazar = "Yiğit HACIEFENDİOĞLU" },
                new BilgeSoz { Id = 2, Soz = "May the source be with you", Yazar = "Sinan \" Yoda \" TAŞYAPAR" },
                new BilgeSoz { Id = 3, Soz = "Habibi come to Dubai", Yazar = "Batuhan HAYBEK" },
                new BilgeSoz { Id = 4, Soz = "Ne olursan ol yine de gel", Yazar = "Ozan GENÇ" },
                new BilgeSoz { Id = 5, Soz = "Sinan anladın mı, Ozan anladın mı, Batuhan anladın mı, Emrah anladın mı, Dogukan, Serdar, Taylan, Yasin, Ceren, Gamze, Kiziltan herkes anladıysa devam edelim", Yazar = "Alp CEYHAN" }                
                );
        }
    }
}
