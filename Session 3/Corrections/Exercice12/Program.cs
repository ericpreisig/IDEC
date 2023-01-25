namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer une phrase : ");
            string phrase = Console.ReadLine();

            int nombreMot = 1;

            foreach (char caractere in phrase)
            {
                if (caractere == ' ')
                {
                    nombreMot++;
                }
            }

            Console.WriteLine("La phrase contien " + nombreMot + " mots");

            Console.ReadLine();
        }
    }
}
