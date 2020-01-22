using McDonalds.Kiosk.DatabaseContext.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace McDonalds.Kiosk.DatabaseContext.Extensions
{
    public static class DrinkQueryExtensions
    {
        public static IEnumerable<DrinkEntity> GetHotDrinks(this IQueryable<DrinkEntity> drinkEntity)
            => drinkEntity.Where(r => r.IsHot);

        public static IEnumerable<DrinkEntity> GetColdDrinks(this IQueryable<DrinkEntity> drinkEntity)
            => drinkEntity.Where(r => !r.IsHot);
    }
}
