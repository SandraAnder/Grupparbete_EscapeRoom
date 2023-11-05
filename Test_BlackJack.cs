using System;
using System.Collections.Generic;
using System.Linq;

public class BlackJack
{
    public void PlayBlackJack()
    {
        while (true)
        {
            Card.Deck deck = new Card.Deck();
            deck.Shuffle();

            Hand playerHand = new Hand(2, deck);
            Hand dealerHand = new Hand(2, deck);

            Console.WriteLine("Välkommen till BlackJack-bordet. Spela och se om du kan vinna... ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Dina kort:");
            foreach (Card card in playerHand.Cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("Totalt: " + playerHand.CalculateValue());

            Console.WriteLine("\nHusets uppvända kort: ");
            Console.WriteLine(dealerHand.Cards.First());

            while (true)
            {
                Console.Write("Vill du 'få' ett kort eller 'stanna'? ");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();

                if (input == "få")
                {
                    playerHand.AddCard(deck.DrawCard());
                    Console.WriteLine("Din hand:");
                    foreach (Card card in playerHand.Cards)
                    {
                        Console.WriteLine(card);
                    }
                    int playerScore = playerHand.CalculateValue();
                    Console.WriteLine("Totalt: " + playerScore);
                    Console.WriteLine("-------------------------");

                    if (playerScore > 21)
                    {
                        Console.WriteLine("Bust! Du förlorar...");
                        Console.WriteLine("-------------------------");
                        break;
                    }
                }
                else if (input == "stanna")
                {
                    int dealerScore = dealerHand.CalculateValue();
                    Console.WriteLine("Husets kort:");
                    foreach (Card card in dealerHand.Cards)
                    {
                        Console.WriteLine(card);
                    }
                    Console.WriteLine("Totalt: " + dealerScore);

                    while (dealerScore < 17)
                    {
                        dealerHand.AddCard(deck.DrawCard());
                        dealerScore = dealerHand.CalculateValue();
                        Console.WriteLine("Huset tar...");
                        Console.WriteLine("Husets kort:");
                        foreach (Card card in dealerHand.Cards)
                        {
                            Console.WriteLine(card);
                        }
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Totalt: " + dealerScore);
                    }

                    if (dealerScore > 21 || playerHand.CalculateValue() > dealerScore)
                    {
                        Console.WriteLine("Du vann! Du får en lapp från huset där det står 'Pacman'.");
                    }
                    else if (playerHand.CalculateValue() == dealerScore)
                    {
                        Console.WriteLine("Det blev lika!");
                    }
                    else
                    {
                        Console.WriteLine("Huset vinner!");
                    }

                    break;
                }
            }

            Console.Write("Vill du spela igen? (ja/nej) ");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain != "ja")
            {
                Console.WriteLine("Tack för att du spelat!");
                return;
            }
        }
    }
}

public class Card
{
    public enum CardValue
    {
        Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }

    public enum CardSuit
    {
        Hjärter,
        Spader,
        Klöver,
        Ruter
    }

    public CardValue Value { get; }
    public CardSuit Suit { get; }
    public string DisplayValue => Value == CardValue.Ace ? "Ess" : Value.ToString("D");

    public Card(CardValue value, CardSuit suit)
    {
        Value = value;
        Suit = suit;
    }

    public override string ToString()
    {
        return $"{Suit} {DisplayValue}";
    }

    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new Exception("Kortleken är tom");
            }

            var drawnCard = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return drawnCard;
        }
    }
}

public class Hand
{
    private List<Card> cards;

    public List<Card> Cards => cards;

    public Hand(int startingHand, Card.Deck deck)
    {
        cards = new List<Card>();
        for (int i = 0; i < startingHand; i++)
        {
            cards.Add(deck.DrawCard());
        }
    }

    public int CalculateValue()
    {
        int value = 0;
        int numberOfAces = 0;

        foreach (var card in cards)
        {
            if (card.Value == Card.CardValue.Ace)
            {
                numberOfAces++;
            }

            if (card.Value >= Card.CardValue.Ten)
            {
                value += 10;
            }
            else
            {
                value += (int)card.Value;
            }
        }

        while (numberOfAces > 0 && value > 21)
        {
            value -= 10;
            numberOfAces--;
        }

        return value;
    }
    public void AddCard(Card card)
    {
        cards.Add(card);
    }
}
