namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] results = new int[] { 0, 0, 0, 0, 0, 0 };

            Console.Write("Nombre de lancés : ");
            int number = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                int result = random.Next(1, 7);
                results[result - 1]++;
            }

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine("Pour le chiffre " + (i + 1) + " le nombre de lancés est de " + results[i]);
            }

            Console.ReadLine();
        }
    }
}
