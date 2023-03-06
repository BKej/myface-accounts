using System.ComponentModel.DataAnnotations;

namespace MyFace.Models.Request
{
    public class CreateUserRequest
    {
        [Required]
        [StringLength(70)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(70)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [StringLength(70)]
        public string Username { get; set; }
        
        public string ProfileImageUrl { get; set; }
        
        public string CoverImageUrl { get; set; }

        [Required]
        [StringLength(25)]
        public string password {get; set; }
        
    }
}