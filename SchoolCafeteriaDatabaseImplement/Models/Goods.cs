using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class Goods
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int BruttoMass { get; set; }

        [Required]
        public int NettoMass { get; set; }

        public bool MarkToDelete { get; set; }

        [ForeignKey("GoodsId")]
        public virtual GoodsComposition GoodsComposition { get; set; }

        [ForeignKey("GoodsId")]
        public virtual List<TechMapGoods> TechMapGoods { get; set; }
    }
}
