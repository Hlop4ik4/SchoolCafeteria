﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class DishOrder
    {
        public int Id { get; set; }

        public int DishId { get; set; }

        public int OrderId { get; set; }

        public virtual Dish Dish { get; set; }

        public virtual Order Order { get; set; }
    }
}
