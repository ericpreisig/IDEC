namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            bool isPair = nombre % 2 == 0;

            Console.Write("Le nombre " + nombre + " est ");

            if (isPair)
            {
                Console.Write("pair !");
            }
            else
            {
                Console.Write("impaire !");
            }

            Console.ReadLine();
        }    
    }
}
