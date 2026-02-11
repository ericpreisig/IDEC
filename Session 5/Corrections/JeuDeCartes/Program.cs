namespace JeuDeCartes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter le nom du joueur 1");
            Joueur joueur1 = new Joueur(Console.ReadLine());
            Console.WriteLine("Enter le nom du joueur 2");
            Joueur joueur2 = new Joueur(Console.ReadLine());

            var jeu = new Jeu(joueur1, joueur2);
            jeu.Start();
        }
    }
}
