using System.ComponentModel.DataAnnotations;

namespace GenericServicesCrud.DTO
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "User Name or Email is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
