using System;

namespace Avocado.Dtos
{
    public record UserDto
    {
        
        public Guid Id { get; init; }

        public string Username { get; init; }

        public string Email { get; init; }

        public string Name { get; init; }

        public string SecondName { get; init; }
    }
}