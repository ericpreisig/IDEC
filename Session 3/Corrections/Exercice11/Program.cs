namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer une phrase : ");
            string phrase = Console.ReadLine();

            for(int i = phrase.Length-1; i >= 0; i--)
            {
                Console.Write(phrase[i]);
            }

            Console.ReadLine();
        }
    }
}
