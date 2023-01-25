namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre d'element à calculer : ");
            int number = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write(a + " " + b);
            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
