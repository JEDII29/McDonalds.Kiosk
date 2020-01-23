using McDonalds.Kiosk.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace McDonalds.Kiosk.DatabaseContext.Entities
{
    [Table("Food")]
    public class FoodEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "nvarchar(24)")]
        public FoodType FoodType { get; set; }

        [Column(TypeName = "nvarchar(9)")]
        public FoodSize FoodSize { get; set; }

        public double Price { get; set; }

        [ForeignKey("Id")]
        public ProductIdEntity ProductId { get; set; }
    }
}
