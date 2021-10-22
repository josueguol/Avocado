using System.ComponentModel.DataAnnotations;

namespace Avocado.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; init; }

        [Required]
        public string Email { get; init; }

        public string Name { get; init; }

        public string SecondName { get; init; }
    }
}