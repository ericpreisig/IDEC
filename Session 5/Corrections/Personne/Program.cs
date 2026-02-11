namespace Personne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne alice = new Personne("Alice", 25);
            Personne jeson = new Personne("Jeson", 36);

            jeson.SePresenter();
            alice.SePresenter();
        }
    }
}
