using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class TechMapGoods
    {
        public int Id { get; set; }

        public int TechMapId { get; set; }

        public int GoodsId { get; set; }

        public virtual TechnologicalMap TechMap { get; set; }

        public virtual Goods Goods { get; set; }
    }
}
