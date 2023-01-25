namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le nombre : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Entrer la puissance : ");
            int puissance = int.Parse(Console.ReadLine());

            int resualt = Puissance(x, puissance);
            Console.WriteLine("La puissance est de : " + resualt);

            Console.ReadLine();
        }

        private static int Puissance(int x, int puissance)
        {
            if(puissance == 0)
            {
                return 1;
            }

            int resultat = x;

            for (int i = 1; i < puissance; i++)
            {
                resultat *= x;
            }

            return resultat;
        }
    }
}
