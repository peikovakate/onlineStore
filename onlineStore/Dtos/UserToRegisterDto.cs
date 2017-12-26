using System.ComponentModel.DataAnnotations;

namespace onlineStore.Dtos
{
    public class UserToRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="You must specify a password between 8 and 20 characters")]
        public string Password { get; set; }
    }
}
