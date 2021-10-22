using Avocado.Dtos;
using Avocado.Entities;

namespace Avocado
{
    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name,
                SecondName = user.SecondName
            };
        }
    }
}