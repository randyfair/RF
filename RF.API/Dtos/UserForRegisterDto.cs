using System.ComponentModel.DataAnnotations;

namespace RF.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]        
        public string Username { get; set; }

        [Required]
        [StringLength(16,MinimumLength = 4, ErrorMessage="Password must be between 8 and 16 characters")]
        public string Password { get; set; }
    }
}