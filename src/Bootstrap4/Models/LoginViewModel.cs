using System.ComponentModel.DataAnnotations;

namespace Bootstrap4.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}