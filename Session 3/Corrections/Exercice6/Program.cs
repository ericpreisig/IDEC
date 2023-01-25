namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrer le rayon du cercle : ");
            double r = double.Parse(Console.ReadLine());

            double surface = Surface(r);
            double circonference = Circonference(r);

            Console.WriteLine("La surface est de : " + surface);
            Console.WriteLine("La circonférence est de : " + circonference);

            Console.ReadLine();
        }

        private static double Surface(double r)
        {
            return Math.PI * r * r;
        }

        private static double Circonference(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
