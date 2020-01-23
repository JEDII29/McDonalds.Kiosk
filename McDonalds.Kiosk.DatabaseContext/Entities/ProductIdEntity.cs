using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McDonalds.Kiosk.DatabaseContext.Entities
{
    [Table("ProductId")]
    public class ProductIdEntity
    {
        [Key]
        public int Id { get; set; }

        public virtual DrinkEntity Drink { get; set; }
        public virtual FoodEntity Food { get; set; }
    }
}
