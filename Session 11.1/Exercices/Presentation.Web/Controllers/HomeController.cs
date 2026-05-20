using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.Web.Data;
using Presentation.Web.Models;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductionDbContext _context;

        public HomeController(ILogger<HomeController> logger, ProductionDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
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

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string login, string password)
        {
            User? user = _context.Users.SingleOrDefault(u => u.Login == login);

            if (user == null || user.Password != HashPassword(password))
            {
                ViewBag.ErrorMessage = "Login ou mot de passe incorrect.";
                return View("Index");
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, user.Login)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        [Authorize]
        public IActionResult Login()
        {
            var userViewModel = new UserViewModel()
            {
                Id = GetCurrentUserId(),
                Login = User.Identity?.Name ?? string.Empty
            };

            return View(userViewModel);
        }

        [AllowAnonymous]
        public IActionResult NewAccount()
        {
            return View();
        }

        [Authorize]
        public IActionResult Users()
        {
            var users = _context.Users.ToList();
            var usersViewModel = new UsersViewModel()
            {
                Logins = users.Select(u => u.Login).ToList()
            };
            return View(usersViewModel);
        }

        [Authorize]
        public IActionResult UpdateAccount(int id)
        {
            if (id != GetCurrentUserId())
            {
                return Forbid();
            }

            var userUpdateViewModel = new UserUpdateViewModel()
            {
                Id = id,
            };

            return View(userUpdateViewModel);
        }

        [Authorize]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            if (id != GetCurrentUserId())
            {
                return Forbid();
            }

            User user = _context.Users.Single(u => u.Id == id);
            _context.Users.Remove(user);
            _context.SaveChanges();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(string login, string password)
        {
            if (_context.Users.Any(u => u.Login == login))
            {
                ViewBag.ErrorMessage = "Ce login existe deja.";
                return View("NewAccount");
            }

            User user = new User
            {
                Login = login,
                Password = HashPassword(password)
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Update(int id, string login, string password)
        {
            if (id != GetCurrentUserId())
            {
                return Forbid();
            }

            if (_context.Users.Any(u => u.Id != id && u.Login == login))
            {
                ViewBag.ErrorMessage = "Ce login existe deja.";
                return View("UpdateAccount", new UserUpdateViewModel { Id = id });
            }

            User user = _context.Users.Single(u => u.Id == id);

            user.Login = login;
            user.Password = HashPassword(password);

            _context.SaveChanges();
            return RedirectToAction(nameof(Login));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Index));
        }

        private int GetCurrentUserId()
        {
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.TryParse(userId, out int id) ? id : 0;
        }

        private static string HashPassword(string password)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(bytes);
        }
    }
}
