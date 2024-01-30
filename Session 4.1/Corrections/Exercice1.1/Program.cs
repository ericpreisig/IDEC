namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> seenNumber = new List<int>();
            Random random = new Random();
            int max = 100;

            do
            {
                int number = random.Next(1, max + 1);

                Console.WriteLine("Avez-vous déjà vu ce nombre ?");
                Console.WriteLine(number);

                string response = GetInput();

                if (response == "oui" && !seenNumber.Contains(number))
                {
                    break;
                }
                else if (response == "non" && seenNumber.Contains(number))
                {
                    break;
                }
                else if (response == "non")
                {
                    seenNumber.Add(number);
                }

            } while (seenNumber.Count < max);

            if(seenNumber.Count == max)
            {
                Console.WriteLine("Vous avez gagné");
            }
            else
            {
                Console.WriteLine($"Vous avez perdu, votre score est de {seenNumber.Count}");
            }
        }

        private static string GetInput()
        {
            string response;
            do
            {
                response = Console.ReadLine();
            } while (response != "oui" && response != "non");
            return response;
        }
    }
}