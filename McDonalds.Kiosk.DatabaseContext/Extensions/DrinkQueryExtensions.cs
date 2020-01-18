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
        public static async Task<IEnumerable<DrinkEntity>> GetHotDrinks(this IQueryable<DrinkEntity> drinkEntity,
            CancellationToken cancellationToken = default)
            => await drinkEntity.Where(r => r.IsHot).ToListAsync(cancellationToken);

        public static async Task<IEnumerable<DrinkEntity>> GetColdDrinks(this IQueryable<DrinkEntity> drinkEntity,
            CancellationToken cancellationToken = default)
            => await drinkEntity.Where(r => !r.IsHot).ToListAsync(cancellationToken);
    }
}
