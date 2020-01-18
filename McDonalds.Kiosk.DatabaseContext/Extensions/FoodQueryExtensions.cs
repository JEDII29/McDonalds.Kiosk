using McDonalds.Kiosk.DatabaseContext.Entities;
using McDonalds.Kiosk.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McDonalds.Kiosk.DatabaseContext.Extensions
{
    public static class FoodQueryExtensions
    {
        public static async Task<IEnumerable<FoodEntity>> GetBurgers(this IQueryable<FoodEntity> foodEntity)
            => await foodEntity.Where(r => r.FoodType == FoodType.Burger).ToListAsync();

        public static async Task<IEnumerable<FoodEntity>> GetWraps(this IQueryable<FoodEntity> foodEntity)
            => await foodEntity.Where(r => r.FoodType == FoodType.Wrap).ToListAsync();

        public static async Task<IEnumerable<FoodEntity>> GetSides(this IQueryable<FoodEntity> foodEntity)
            => await foodEntity
            .Where(r => r.FoodType == FoodType.Chips || r.FoodType == FoodType.Salad)
            .ToListAsync();
    }
}
