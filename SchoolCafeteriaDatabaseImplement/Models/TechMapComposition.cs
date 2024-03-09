using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCafeteriaDatabaseImplement.Models
{
    public class TechMapComposition
    {
        public int Id { get; set; }

        public int TechnologicalMapId { get; set; }

        public decimal Protein { get; set; }

        public decimal Fat { get; set; }

        public decimal Carb { get; set; }

        public decimal B1 { get; set; }

        public decimal C { get; set; }

        public decimal A { get; set; }

        public decimal E { get; set; }

        public decimal Ca { get; set; }

        public decimal P { get; set; }

        public decimal Mg { get; set; }

        public decimal Fe { get; set; }

        public virtual TechnologicalMap TechnologicalMap { get; set; }
    }
}
