namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            List<double> numbers = new List<double>();

            do
            {
                Console.Write($"Entrer {numbers.Count + 1} nombre : ");
                userInput = Console.ReadLine();

                if(string.IsNullOrEmpty(userInput))
                {
                    break;
                }

                if(double.TryParse(userInput, out double number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("L'entrée n'est pas un nombre");
                }
            } while (!string.IsNullOrWhiteSpace(userInput));

            double result = SommeList(numbers);

            Console.WriteLine($"La somme de la liste est : {result}");
        }

        private static double SommeList(List<double> numbers)
        {
            double result = 0;

            foreach(double number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}