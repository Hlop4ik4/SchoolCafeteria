namespace SchoolCafeteriaContracts.ViewModels
{
    public class GoodsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BruttoMass { get; set; }

        public int NettoMass { get; set; }

        public bool MarkToDelete { get; set; }
    }
}
