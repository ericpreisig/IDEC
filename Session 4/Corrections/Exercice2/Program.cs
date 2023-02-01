using System.Collections.Generic;

namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = Game();
            RegisterHighscore(score);
            DisplayUsersScores();
        }

        private static int Game()
        {
            Random rng = new Random();
            Console.WriteLine("Deviner un nombre entre 1 et 100 !");

            int nombreAleatoire = rng.Next(1, 101);
            int nombreUtilisateur;
            int score = 0;

            do
            {
                score++;

                nombreUtilisateur = int.Parse(Console.ReadLine());
                if (nombreUtilisateur > nombreAleatoire)
                {
                    Console.WriteLine("Le chiffre est plus petit !");
                }
                else if (nombreUtilisateur < nombreAleatoire)
                {
                    Console.WriteLine("Le chiffre est plus grand !");
                }
            } while (nombreUtilisateur != nombreAleatoire);

            Console.WriteLine("Victoire !!!");
            return score;
        }

        private static void RegisterHighscore(int score)
        {
            Console.Write("Enter votre pseudo : ");
            string pseudo = Console.ReadLine();

            string[] scoreLine = new string[]
            {
                $"{score} - {pseudo}"
            };

            File.AppendAllLines("score.txt", scoreLine);
        }

        private static void DisplayUsersScores()
        {
            List<string> scores = File.ReadAllLines("score.txt").ToList();

            string currentUserScore = scores.Last();
            string temp;

            for (int i = 0; i < scores.Count - 1; i++)
            {
                for (int j = i + 1; j < scores.Count; j++)
                {
                    string[] splitedScore1 = scores[i].Split(" - ");
                    int score1 = int.Parse(splitedScore1[0]);

                    string[] splitedScore2 = scores[j].Split(" - ");
                    int score2 = int.Parse(splitedScore2[0]);

                    if (score1 < score2)
                    {
                        temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }

            Console.WriteLine("< Affichage des scores >");

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] == currentUserScore)
                {
                    int startIndex = Math.Max(i - 2, 0);
                    int endIndex = Math.Min(i + 2, scores.Count-1);

                    for(int j = startIndex; j <= endIndex; j++)
                    {
                        Console.WriteLine(scores[j]);
                    }
                    break;
                }
            }

        }
    }
}