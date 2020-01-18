using McDonalds.Kiosk.DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace McDonalds.Kiosk.DatabaseContext
{
    public class KioskMySqlContext : DbContext
    {
        public KioskMySqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FoodEntity> Food { get; set; }
        public DbSet<DrinkEntity> Drinks { get; set; }
    }
}
