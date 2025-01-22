class Program
{
    private const double TVA = 8.1;

    static void Main(string[] args)
    {
        Console.Write("Quel est le prix HT : ");
        double prix = double.Parse(Console.ReadLine());

        double prixTva = prix * TVA / 100;
        Console.WriteLine("TTC : " + (prix + prixTva));
        Console.WriteLine("TVA : " + prixTva);

        Console.ReadLine();
    }
}