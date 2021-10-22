using System;
using System.Collections.Generic;
using Avocado.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Avocado.Dtos;
using Avocado.Entities;

namespace Avocado.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IRepository repository;

        public UsersController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET /api/users
        [HttpGet]
        public IEnumerable<UserDto> GetUsers()
        {
            return repository.GetUsers().Select(item => item.AsDto());
        }


        // GET /api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(Guid id)
        {
            var user = repository.GetUser(id);

            if (user is null)
            {
                return NotFound();
            }

            return user.AsDto();
        }

        // POST /api/users
        [HttpPost]
        public ActionResult<UserDto> CreateUser(CreateUserDto userDto)
        {
            User user = new()
            {
                Id = Guid.NewGuid(),
                Email = userDto.Email,
                Username = userDto.Username,
                Name = userDto.Name,
                SecondName = userDto.SecondName
            };

            repository.CreateUser(user);

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user.AsDto());
        }

        // PUT /api/users/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(Guid id, UpdateUserDto userDto)
        {
            var existingUser = repository.GetUser(id);

            if (existingUser is null)
            {
                return NotFound();
            }

            User updateUser = existingUser with
            {
                Email = userDto.Email,
                Name = userDto.Name,
                SecondName = userDto.SecondName
            };

            repository.UpdateUser(updateUser);

            return NoContent();
        }

        // DELETE /api/users/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var existingUser = repository.GetUser(id);

            if (existingUser is null)
            {
                return NotFound();
            }
            
            repository.DeleteUser(id);

            return NoContent();
        }
    }
}