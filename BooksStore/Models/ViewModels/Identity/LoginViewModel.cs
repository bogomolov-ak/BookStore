using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.ViewModels.Identity
{
    public class LoginViewModel
    {
        [Required] 
        public string Name { get; set; }

        [Required] 
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}