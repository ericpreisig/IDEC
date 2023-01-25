Random rng = new Random(100);

for (var i = 0; i< 100; i++)
{
    Console.WriteLine(rng.Next(1, 100000));
}

Console.ReadLine();