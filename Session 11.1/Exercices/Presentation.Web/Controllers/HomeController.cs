using DataLayer.Data;
using DataLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Web.Models;
using System.Diagnostics;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductionDbContext _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new ProductionDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login(string login, string password)
        {
            User user = _context.Users.SingleOrDefault(u => u.Login == login);

            if (user == null || user.Password != password)
            {
                return View("Index");
            }
            else
            {
                var userViewModel = new UserViewModel()
                {
                    Id = user.Id,
                    Login = login
                };
                return View(userViewModel);
            }
        }
        public IActionResult NewAccount()
        {
            return View();
        }

        public IActionResult Users()
        {
            var users = _context.Users.ToList();
            var usersViewModel = new UsersViewModel()
            {
                Logins = users.Select(u => u.Login).ToList()
            };
            return View(usersViewModel);
        }

        public IActionResult UpdateAccount(int id)
        {
            var userUpdateViewModel = new UserUpdateViewModel()
            {
                Id = id,
            };

            return View(userUpdateViewModel);
        }

        public IActionResult DeleteAccount(int id)
        {
            User user = _context.Users.Single(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            return View("Index");
        }        

        public IActionResult Register(string login, string password)
        {
            User user = new User
            {
                Login = login,
                Password = password
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return View("Index");
        }

        public IActionResult Update(int id, string login, string password)
        {
            User user = _context.Users.Single(u => u.Id == id);

            user.Login = login;
            user.Password = password;

            _context.SaveChanges(); return View("Index");
        }
    }
}