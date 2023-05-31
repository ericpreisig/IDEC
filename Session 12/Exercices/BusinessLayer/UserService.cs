using DataLayer.Data;
using DataLayer.Models;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class UserService
    {
        private readonly ProductionDbContext _context;
        public UserService()
        {
            _context = new ProductionDbContext();
        }

        public void Add(string login, string password)
        {
            User user = new User
            {
                Login = login,
                Password = password
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int userId)
        {
            User user = _context.Users.Single(u => u.Id == userId);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void Update(int userId, string newLogin, string newPassword)
        {
            User user = _context.Users.Single(u => u.Id == userId);

            user.Login = newLogin;
            user.Password = newPassword;

            _context.SaveChanges();
        }

        public UserDto Connect(string login, string password)
        {
            User user = _context.Users.SingleOrDefault(u => u.Login == login);

            if (user == null || user.Password != password)
                return null;

            return new UserDto
            {
                Id = user.Id,
                Login = user.Login
            };
        }

        public List<UserDto> GetAll()
        {
            return _context.Users.Select(u => new UserDto()
            {
                Id = u.Id,
                Login = u.Login,
            }).ToList();
        }
    }
}
