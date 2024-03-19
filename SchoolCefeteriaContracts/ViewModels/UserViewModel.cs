using System.ComponentModel.DataAnnotations;

namespace SchoolCafeteriaContracts.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
