Console.WriteLine("Entrer une phrase ?");
string phrase = Console.ReadLine();

for (var i = 0; i < phrase.Length; i++)
{
    if (phrase[i] == 'e')
    {
        Console.WriteLine("Il y a un e à la position : " + (i + 1));
    }
}

Console.ReadLine();
