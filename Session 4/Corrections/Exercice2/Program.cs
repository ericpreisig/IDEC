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

            scores.Sort();

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