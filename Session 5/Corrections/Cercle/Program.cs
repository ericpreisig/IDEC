namespace Cercle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle cercle1 = new Cercle(10);
            Cercle cercle2 = new Cercle(20);

            Console.WriteLine($"L'air du cercle 1 est de : {cercle1.GetSurface()}");
            Console.WriteLine($"L'air du cercle 2 est de : {cercle2.GetSurface()}");

            Console.WriteLine($"Le périmètre du cercle 1 est de : {cercle1.GetPerimetre()}");
            Console.WriteLine($"Le périmètre du cercle 2 est de : {cercle2.GetPerimetre()}");
        }
    }
}