using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{   public class LoginUserDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MinLength(6)]
        public string Password { get; set; } = null!;
    }
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public decimal Balance { get; set; }
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
    public class UpdateUserDto
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MinLength(6)]
        public string Password { get; set; } = null!;
    }
    public class RegisterUserDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MinLength(6)]
        public string Password { get; set; } = null!;

    }

}
