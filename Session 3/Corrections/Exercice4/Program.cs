namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le premier nombre : ");
            int nombre1 = int.Parse(Console.ReadLine());

            Console.Write("Entrer le second nombre : ");
            int nombre2 = int.Parse(Console.ReadLine());

            int somme = Somme(nombre1, nombre2);
            Console.WriteLine("La somme est de : " + somme);

            Console.ReadLine();
        }

        private static int Somme(int a, int b)
        {
            return a + b;
        }
    }
}
