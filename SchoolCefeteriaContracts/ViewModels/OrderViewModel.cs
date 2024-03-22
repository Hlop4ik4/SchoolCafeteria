using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCefeteriaContracts.ViewModels
{
    public class OrderViewModel
    {
        public string Id { get; set; }

        public string Price { get; set; }

        public string SumToPay { get; set; }

        public List<string> DishOrder { get; set; }
    }
}
