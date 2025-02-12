using System;

class Program
{
    static void Main()
    {
        Chien rex = new Chien("Rex");
        rex.Manger();
        rex.Dormir();

        Chat milo = new Chat("Milo");
        milo.Manger();
        milo.Dormir();
    }
}
