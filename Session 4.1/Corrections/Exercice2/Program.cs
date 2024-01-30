using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var deck = GenerateDeck();
        var player1Deck = new List<int>(deck.Take(26));
        var player2Deck = new List<int>(deck.Skip(26));

        int roundCount = 0;

        while (player1Deck.Any() && player2Deck.Any())
        {
            Console.WriteLine("Appuyez sur « Enter » pour jouer un tour...");
            Console.ReadLine();

            PlayRound(player1Deck, player2Deck);
            roundCount++;
        }

        Console.WriteLine($"Nombre de tours joués : {roundCount}");
        if (player1Deck.Any())
        {
            Console.WriteLine("Joueur 1 gagne le jeu !");
        }
        else
        {
            Console.WriteLine("Joueur 2 gagne le jeu !");
        }
    }

    static void PlayRound(List<int> player1Deck, List<int> player2Deck)
    {
        if (!player1Deck.Any() || !player2Deck.Any())
        {
            return;
        }

        var player1Card = player1Deck.First();
        player1Deck.RemoveAt(0);
        var player2Card = player2Deck.First();
        player2Deck.RemoveAt(0);

        Console.WriteLine($"Joueur 1 joue : {CardToString(player1Card)}");
        Console.WriteLine($"Joueur 2 joue : {CardToString(player2Card)}");

        List<int> cardsOnTable = new List<int> { player1Card, player2Card };

        if (player1Card > player2Card)
        {
            Console.WriteLine("Joueur 1 remporte la manche !");
            player1Deck.AddRange(cardsOnTable);
        }
        else if (player2Card > player1Card)
        {
            Console.WriteLine("Joueur 2 remporte la manche !");
            player2Deck.AddRange(cardsOnTable);
        }
        else
        {
            Console.WriteLine("Bataille !");
            if (player1Deck.Count > 0 && player2Deck.Count > 0)
            {
                PlayRound(player1Deck, player2Deck);
            }
        }
    }

    static List<int> GenerateDeck()
    {
        var deck = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                deck.Add(j);
            }
        }

        var random = new Random();
        deck = deck.OrderBy(x => random.Next()).ToList();
        return deck;
    }

    static string CardToString(int cardValue)
    {
        switch (cardValue)
        {
            case 11:
                return "Valet";
            case 12:
                return "Dame";
            case 13:
                return "Roi";
            case 14:
                return "As";
            default:
                return cardValue.ToString();
        }
    }
}