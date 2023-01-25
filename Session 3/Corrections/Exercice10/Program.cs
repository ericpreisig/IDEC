namespace Exercice10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 2, 4, 3, 5, 8 };

            foreach (var element in tableau)
            {
                if (element % 2 == 0)
                {
                    Console.WriteLine("Le chiffre " + element + " est pair");
                }
                else
                {
                    Console.WriteLine("Le chiffre " + element + " est impair");
                }
            }

            Console.ReadLine();
        }
    }
}
