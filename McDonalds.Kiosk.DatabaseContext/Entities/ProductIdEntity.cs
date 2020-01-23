using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace McDonalds.Kiosk.DatabaseContext.Entities
{
    [Table("ProductId")]
    public class ProductIdEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<DrinkEntity> Drinks { get; set; }
        public ICollection<FoodEntity> Food { get; set; }
    }
}
