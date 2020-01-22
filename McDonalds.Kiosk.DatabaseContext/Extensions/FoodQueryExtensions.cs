using McDonalds.Kiosk.Core.Enums;
using McDonalds.Kiosk.DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace McDonalds.Kiosk.DatabaseContext.Extensions
{
    public static class FoodQueryExtensions
    {
        public static IEnumerable<FoodEntity> GetBurgers(this IQueryable<FoodEntity> foodEntity)
            => foodEntity.Where(r => r.FoodType == FoodType.Burger);

        public static IEnumerable<FoodEntity> GetWraps(this IQueryable<FoodEntity> foodEntity)
            => foodEntity.Where(r => r.FoodType == FoodType.Wrap);

        public static IEnumerable<FoodEntity> GetSides(this IQueryable<FoodEntity> foodEntity)
            => foodEntity
            .Where(r => r.FoodType == FoodType.Chips || r.FoodType == FoodType.Salad);
    }
}
