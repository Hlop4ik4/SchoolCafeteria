using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public decimal SumToPay { get; set; }

        [ForeignKey("OrderId")]
        public virtual List<DishOrder> DishOrders { get; set; }
    }
}
