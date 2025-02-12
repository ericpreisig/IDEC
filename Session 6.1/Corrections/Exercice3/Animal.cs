class Animal
{
    public string Nom { get; set; }

    public Animal(string nom)
    {
        Nom = nom;
    }

    public void Manger()
    {
        Console.WriteLine($"{Nom} mange.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nom} dort.");
    }
}
