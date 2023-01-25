namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] voyelles = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
                   
            Console.Write("Entrer une phrase : ");
            string phrase = Console.ReadLine();

            int nombreVoyelles = 0;
            foreach (char caracter in phrase)
            {
                foreach (char voyelle in voyelles)
                {
                    if (caracter == voyelle)
                    {
                        nombreVoyelles++;
                    }
                }
            }

            Console.WriteLine("Il y a " + nombreVoyelles + " voyelles dans la phrase");
            Console.ReadLine();
        }
    }
}
