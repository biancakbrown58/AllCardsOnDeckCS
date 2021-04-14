using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var face = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var suit = new List<string>() { "Diamond", "Heart", "Club", "Spade" };

            // var oneCard = new List<string>();
            var deck = new List<string>();

            // var numberOfCards = suit.Count();
            // var randomCardGenerator = new Random();
            // var randomNumber = randomCardGenerator.Next();


            for (var rightIndex = 0; rightIndex < suit.Count; rightIndex++)
            {
                for (var leftIndex = 0; leftIndex < face.Count; leftIndex++)
                {
                    //adds cards to empty deck list
                    var card = $"{suit[rightIndex]} of {face[leftIndex]}";
                    deck.Add(card);
                }
                //displays the each one card in the deck

            }
            foreach (var oneCard in deck)
            {
                Console.WriteLine(oneCard);
            }
            Console.WriteLine("-----------------");
            // numberOfCards = length of our deck
            var numberOfCards = deck.Count;
            for (var rightSide = numberOfCards - 1; rightSide >= 0; rightSide--)
            {
                var leftSide = new Random().Next(0, rightSide);
                var rightCard = deck[rightSide];
                deck[rightSide] = deck[leftSide];
                deck[leftSide] = rightCard;

            }
            foreach (var oneCard in deck)
            {
                Console.WriteLine(oneCard);
            }

        }
    }
}
