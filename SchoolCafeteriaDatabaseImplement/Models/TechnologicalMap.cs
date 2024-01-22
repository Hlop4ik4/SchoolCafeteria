using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class TechnologicalMap
    {
        public int Id { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        public int RecipeNumber { get; set; }

        public string CookingTechnology { get; set; }

        public string Description { get; set; }

        [ForeignKey("TechMapId")]
        public virtual GoodsComposition GoodsComposition { get; set; }

        [ForeignKey("TechMapId")]
        public virtual List<TechMapGoods> TechMapGoods { get; set; }
    }
}
