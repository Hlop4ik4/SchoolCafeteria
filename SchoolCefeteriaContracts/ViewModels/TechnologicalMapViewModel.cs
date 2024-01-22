namespace SchoolCafeteriaContracts.ViewModels
{
    public class TechnologicalMapViewModel
    {
        public int? Id { get; set; }

        public string DishName { get; set; }

        public int RecipeNumber { get; set; }

        public string CookingTechnology { get; set; }

        public string Description { get; set; }

        public List<int> TechMapGoods { get; set; }
    }
}
