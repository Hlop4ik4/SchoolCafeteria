namespace SchoolCafeteriaContracts.ViewModels
{
    public class TechnologicalMapViewModel
    {
        public string? Id { get; set; }

        public string DishName { get; set; }

        public string RecipeNumber { get; set; }

        public string CookingTechnology { get; set; }

        public string Description { get; set; }

        public List<string> TechMapGoods { get; set; }
    }
}
