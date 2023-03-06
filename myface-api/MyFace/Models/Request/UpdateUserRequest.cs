namespace MyFace.Models.Request
{
    public class UpdateUserRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }

        public string HashedPassword {get; set;}

        public string Salt {get; set;}
    }
}