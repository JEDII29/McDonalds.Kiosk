using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McDonalds.Kiosk.DatabaseContext.Entities
{
    [Table("Drink")]
    public class DrinkEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int AmountInMilliliters { get; set; }
        public bool IsHot { get; set; }
        public double Price { get; set; }

        [ForeignKey("Id")]
        public virtual ProductIdEntity ProductId { get; set; }
    }
}
