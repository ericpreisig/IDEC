namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le premier coté (x) : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Entrer le second coté (y) : ");
            int y = int.Parse(Console.ReadLine());

            int surface = Surface(x, y);
            Console.WriteLine("La surface est de : " + surface);

            Console.ReadLine();
        }

        private static int Surface(int x, int y)
        {
            return x * y;
        }
    }
}
