using BusinessLayer;
using DTO;
using System;

namespace Presentation
{
    class Program
    {
        private static UserService _userRepository;
        static void Main(string[] args)
        {
            _userRepository = new UserService();
            MainMenu();
            Console.ReadLine();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Inscription");
            Console.WriteLine("2 : Connexion");

            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    SignUp();
                    break;
                case 2:
                    Connect();
                    break;
                default:
                    MainMenu();
                    break;
            }       
        }

        private static void Connect()
        {
            Console.Clear();
            UserDto user;
            do
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Mot de passe: ");
                string password = Console.ReadLine();

                user = _userRepository.Connect(login, password);

                if(user == null)
                {
                    Console.WriteLine("Login impossible !");
                }
            } while (user == null);

            Connected(user);
        }

        private static void Connected(UserDto user)
        {
            Console.Clear();
            Console.WriteLine($"Bonjour {user.Login}");

            Console.WriteLine("1 : Mettre a jour mes données");
            Console.WriteLine("2 : Supprimer mon compte");

            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 1:
                    UpdateAccount(user);
                    break;
                case 2:
                    DeleteAccount(user);
                    break;
                default:
                    MainMenu();
                    break;
            }
        }

        private static void UpdateAccount(UserDto user)
        {
            Console.Clear();
            Console.Write("Nouveau login: ");
            string login = Console.ReadLine();
            Console.Write("Nouveau mot de passe: ");
            string password = Console.ReadLine();

            _userRepository.Update(user.Id, login, password);

            Console.WriteLine("Le compte a bien été mis à jour");
        }

        private static void DeleteAccount(UserDto user)
        {
            Console.Clear();
            _userRepository.Delete(user.Id);
            Console.WriteLine("Le compte a bien été supprimé");
        }

        private static void SignUp()
        {
            Console.Clear();
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Mot de passe: ");
            string password = Console.ReadLine();

            _userRepository.Add(login, password);
            MainMenu();
        }
    }
}
