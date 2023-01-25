namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veillez choisir la plage de température actuel");

            Console.WriteLine("Option 1 : > 15°");
            Console.WriteLine("Option 2 : < 10°");
            Console.WriteLine("Option 3 : > 30°");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Température idéal");
                    break;
                case 2:
                    Console.WriteLine("Attention au verglas");
                    break;
                case 3:
                    Console.WriteLine("Attention au soleil");
                    break;
                default:
                    Console.WriteLine("Option non définie");
                    break;
            }

            Console.ReadLine();
        }
    }
}
