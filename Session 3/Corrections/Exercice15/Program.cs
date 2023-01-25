namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 2, 4, 3, 5, 8, 65, 3 };

            for (int i = 0; i < tableau.Length; i++)
            {
                bool isDuplicateFound = false;
                for (int j = 0; j < tableau.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (tableau[i] == tableau[j])
                    {
                        Console.WriteLine("Le chiffre " + tableau[i] + " est dupliqué");
                        isDuplicateFound = true;
                        break;
                    }
                }
                if(isDuplicateFound)
                {
                    break;
                }
            }

            Console.ReadLine();

        }
    }
}
