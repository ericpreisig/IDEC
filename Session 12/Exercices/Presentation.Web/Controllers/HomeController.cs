using BusinessLayer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Presentation.Web.Models;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Web.Controllers
{    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserService _userRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _userRepository = new UserService();
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
            var user = _userRepository.Connect(login, password);

            if (user != null)
            {
                var userViewModel = new UserViewModel() 
                { 
                    Id = user.Id,
                    Login = login 
                };

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Login),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity)).Wait();

                return View(userViewModel);
            }
            else
            {
                TempData["error"] = "Une erreur est survenue lors de la connexion";
                return View("Index");
            }
        }

        [Authorize]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync().Wait();
            return View("Index");
        }

        public IActionResult NewAccount()
        {
            return View();
        }

        public IActionResult Users()
        {
            var users = _userRepository.GetAll();
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
            _userRepository.Delete(id);
            return View("Index");
        }        

        public IActionResult Register(string login, string password)
        {
            _userRepository.Add(login, password);
            return View("Index");
        }

        public IActionResult Update(int id, string login, string password)
        {       
            _userRepository.Update(id, login, password);
            return View("Index");
        }
    }
}