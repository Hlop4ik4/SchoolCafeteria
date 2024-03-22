using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("DishId")]
        public virtual List<DishOrder> DishOrders { get; set; }
    }
}
