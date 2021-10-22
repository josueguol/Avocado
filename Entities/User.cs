using System;

namespace Avocado.Entities
{
    public record User
    {
        public Guid Id { get; init; }

        public string Username { get; init; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }
    }
}