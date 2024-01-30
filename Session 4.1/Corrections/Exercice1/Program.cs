using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice1
{
    internal class Program
    {
        private static List<int> _seenList = new List<int>();
        private static List<int> _notSeenList = Enumerable.Range(1, 100).ToList();

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du déjà-vu");
            Random random = new Random();

            bool endGame = false;
            int score = 0;

            while (!endGame && _notSeenList.Count > 0)
            {
                int displayNumber = ChooseNumber(random);
                Console.WriteLine($"Avez-vous déjà vu ce nombre : {displayNumber} ? (oui/non)");
                string input = GetUserInput();

                if ((input == "oui" && !_seenList.Contains(displayNumber)) || (input == "non" && _seenList.Contains(displayNumber)))
                {
                    endGame = true;
                }

                UpdateLists(displayNumber, input);

                if (!endGame) score++;
                Console.Clear();
            }

            Console.WriteLine(_notSeenList.Count == 0 ? "Vous avez gagné !" : "Vous avez perdu !");
            Console.WriteLine($"Votre score est de {score}");
        }

        static int ChooseNumber(Random random)
        {
            bool showNewNumber = _seenList.Count == 0 || random.Next(0, 2) == 0;
            return showNewNumber ? _notSeenList[random.Next(_notSeenList.Count)] : _seenList[random.Next(_seenList.Count)];
        }

        static string GetUserInput()
        {
            string input;
            do
            {
                input = Console.ReadLine();
            } while (input != "oui" && input != "non");

            return input;
        }

        static void UpdateLists(int number, string input)
        {
            if (input == "non" && !_seenList.Contains(number))
            {
                _seenList.Add(number);
                _notSeenList.Remove(number);
            }
        }
    }
}
