using System;
using Lab7_Collection.Classes;

namespace Lab7_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Deck<Cards> gameDeck = CreateFullDeck();
            //int count = gameDeck.GetCount();
            //Console.WriteLine($"==========================Start of Deck:({count})=================================");
            ////Print(gameDeck);
            //gameDeck.RemoveCard(52);
            //gameDeck.RemoveCard(51);
            //count = gameDeck.GetCount();
            //Console.WriteLine($"=======================Remove King & Queen of Spades:({count})=============================");
            ////Print(gameDeck);
            //Cards QueenSpades = new Cards(Number.Queen, Suites.Spades);
            //Cards KingSpades = new Cards(Number.King, Suites.Spades);
            //gameDeck.AddCard(QueenSpades);
            //gameDeck.AddCard(KingSpades);
            //count = gameDeck.GetCount();
            //Console.WriteLine($"=======================Add King & Queen of Spades:({count})=============================");
            ////Print(gameDeck);
            //Console.ReadLine();

                                  
            Console.WriteLine("Dealer Hand: 0");
            Console.WriteLine("Player One Hand: 0");
            Console.WriteLine("Player Two Hand: 0");
            Console.WriteLine();
            Console.WriteLine("Hit Enter to deal the cards");
            Console.ReadLine();
            Deal();



        }

        /// <summary>
        /// Its deals the demo cards out to the two players and the dealer
        /// </summary>
        public static void Deal()
        {
            Deck<Cards> gameDeck = Setup();
            Deck<Cards> player1 = new Deck<Cards>();
            Deck<Cards> player2 = new Deck<Cards>();
            Deck<Cards> dealer = new Deck<Cards>();
            int cardCount = gameDeck.GetCount();
            int count = cardCount / 2;
            foreach (Cards card in gameDeck)
            {
                if (player1.GetCount() == count && player2.GetCount() == count)
                {
                    dealer.AddCard(card);
                }
                if (player2.GetCount() < count && player1.GetCount() == count)
                {
                    player2.AddCard(card);
                }
                if (player1.GetCount() < count)
                {
                    player1.AddCard(card);
                }
            }
            Console.Write("Dealer Hand: ");
            Console.ReadLine();
            foreach (Cards card in dealer)
            {
                Console.Write($"{card.CardNumber} of {card.CardSuites} ");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("Player One Hand: ");
            Console.ReadLine();
            foreach (Cards card in player1)
            {
                Console.Write($"{card.CardNumber} of {card.CardSuites} ");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.Write("Player Two Hand: ");
            Console.ReadLine();
            foreach (Cards card in player2)
            {
                Console.Write($"{card.CardNumber} of {card.CardSuites} ");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Generates demo deck
        /// </summary>
        /// <returns>a deck</returns>
        public static Deck<Cards> Setup()
        {
            Deck<Cards> deck = new Deck<Cards>();
            Cards one = new Cards(Number.King, Suites.Diamonds);
            Cards two = new Cards(Number.Ace, Suites.Hearts);
            Cards three = new Cards(Number.Three, Suites.Clubs);
            Cards four = new Cards(Number.King, Suites.Hearts);
            Cards five = new Cards(Number.Ten, Suites.Diamonds);
            deck.AddCard(one);
            deck.AddCard(two);
            deck.AddCard(three);
            deck.AddCard(four);
            deck.AddCard(five);

            return deck;
        }

        /// <summary>
        /// Generates all my hard coded cards and adds them to a Deck
        /// </summary>
        /// <returns>a deck</returns>
        public static Deck<Cards> CreateFullDeck()
        {
            Deck<Cards> deckOfCards = new Deck<Cards>();
            Cards AceHeart = new Cards(Number.Ace, Suites.Hearts);
            Cards TwoHeart = new Cards(Number.Two, Suites.Hearts);
            Cards ThreeHeart = new Cards(Number.Three, Suites.Hearts);
            Cards FourHeart = new Cards(Number.Four, Suites.Hearts);
            Cards FiveHeart = new Cards(Number.Five, Suites.Hearts);
            Cards SixHeart = new Cards(Number.Six, Suites.Hearts);
            Cards SevenHeart = new Cards(Number.Seven, Suites.Hearts);
            Cards EightHeart = new Cards(Number.Eight, Suites.Hearts);
            Cards NineHeart = new Cards(Number.Nine, Suites.Hearts);
            Cards TenHeart = new Cards(Number.Ten, Suites.Hearts);
            Cards JackHeart = new Cards(Number.Jack, Suites.Hearts);
            Cards QueenHeart = new Cards(Number.Queen, Suites.Hearts);
            Cards KingHeart = new Cards(Number.King, Suites.Hearts);
            Cards AceDiamond = new Cards(Number.Ace, Suites.Diamonds);
            Cards TwoDiamond = new Cards(Number.Two, Suites.Diamonds);
            Cards ThreeDiamond = new Cards(Number.Three, Suites.Diamonds);
            Cards FourDiamond = new Cards(Number.Four, Suites.Diamonds);
            Cards FiveDiamond = new Cards(Number.Five, Suites.Diamonds);
            Cards SixDiamond = new Cards(Number.Six, Suites.Diamonds);
            Cards SevenDiamond = new Cards(Number.Seven, Suites.Diamonds);
            Cards EightDiamond = new Cards(Number.Eight, Suites.Diamonds);
            Cards NineDiamond = new Cards(Number.Nine, Suites.Diamonds);
            Cards TenDiamond = new Cards(Number.Ten, Suites.Diamonds);
            Cards JackDiamond = new Cards(Number.Jack, Suites.Diamonds);
            Cards QueenDiamond = new Cards(Number.Queen, Suites.Diamonds);
            Cards KingDiamond = new Cards(Number.King, Suites.Diamonds);
            Cards AceClub = new Cards(Number.Ace, Suites.Clubs);
            Cards TwoClub = new Cards(Number.Two, Suites.Clubs);
            Cards ThreeClub = new Cards(Number.Three, Suites.Clubs);
            Cards FourClub = new Cards(Number.Four, Suites.Clubs);
            Cards FiveClub = new Cards(Number.Five, Suites.Clubs);
            Cards SixClub = new Cards(Number.Six, Suites.Clubs);
            Cards SevenClub = new Cards(Number.Seven, Suites.Clubs);
            Cards EightClub = new Cards(Number.Eight, Suites.Clubs);
            Cards NineClub = new Cards(Number.Nine, Suites.Clubs);
            Cards TenClub = new Cards(Number.Ten, Suites.Clubs);
            Cards JackClub = new Cards(Number.Jack, Suites.Clubs);
            Cards QueenClub = new Cards(Number.Queen, Suites.Clubs);
            Cards KingClub = new Cards(Number.King, Suites.Clubs);
            Cards AceSpades = new Cards(Number.Ace, Suites.Spades);
            Cards TwoSpades = new Cards(Number.Two, Suites.Spades);
            Cards ThreeSpades = new Cards(Number.Three, Suites.Spades);
            Cards FourSpades = new Cards(Number.Four, Suites.Spades);
            Cards FiveSpades = new Cards(Number.Five, Suites.Spades);
            Cards SixSpades = new Cards(Number.Six, Suites.Spades);
            Cards SevenSpades = new Cards(Number.Seven, Suites.Spades);
            Cards EightSpades = new Cards(Number.Eight, Suites.Spades);
            Cards NineSpades = new Cards(Number.Nine, Suites.Spades);
            Cards TenSpades = new Cards(Number.Ten, Suites.Spades);
            Cards JackSpades = new Cards(Number.Jack, Suites.Spades);
            Cards QueenSpades = new Cards(Number.Queen, Suites.Spades);
            Cards KingSpades = new Cards(Number.King, Suites.Spades);

            deckOfCards.AddCard(AceHeart);
            deckOfCards.AddCard(TwoHeart);
            deckOfCards.AddCard(ThreeHeart);
            deckOfCards.AddCard(FourHeart);
            deckOfCards.AddCard(FiveHeart);
            deckOfCards.AddCard(SixHeart);
            deckOfCards.AddCard(SevenHeart);
            deckOfCards.AddCard(EightHeart);
            deckOfCards.AddCard(NineHeart);
            deckOfCards.AddCard(TenHeart);
            deckOfCards.AddCard(JackHeart);
            deckOfCards.AddCard(QueenHeart);
            deckOfCards.AddCard(KingHeart);
            deckOfCards.AddCard(AceDiamond);
            deckOfCards.AddCard(TwoDiamond);
            deckOfCards.AddCard(ThreeDiamond);
            deckOfCards.AddCard(FourDiamond);
            deckOfCards.AddCard(FiveDiamond);
            deckOfCards.AddCard(SixDiamond);
            deckOfCards.AddCard(SevenDiamond);
            deckOfCards.AddCard(EightDiamond);
            deckOfCards.AddCard(NineDiamond);
            deckOfCards.AddCard(TenDiamond);
            deckOfCards.AddCard(JackDiamond);
            deckOfCards.AddCard(QueenDiamond);
            deckOfCards.AddCard(KingDiamond);
            deckOfCards.AddCard(AceClub);
            deckOfCards.AddCard(TwoClub);
            deckOfCards.AddCard(ThreeClub);
            deckOfCards.AddCard(FourClub);
            deckOfCards.AddCard(FiveClub);
            deckOfCards.AddCard(SixClub);
            deckOfCards.AddCard(SevenClub);
            deckOfCards.AddCard(EightClub);
            deckOfCards.AddCard(NineClub);
            deckOfCards.AddCard(TenClub);
            deckOfCards.AddCard(JackClub);
            deckOfCards.AddCard(QueenClub);
            deckOfCards.AddCard(KingClub);
            deckOfCards.AddCard(AceSpades);
            deckOfCards.AddCard(TwoSpades);
            deckOfCards.AddCard(ThreeSpades);
            deckOfCards.AddCard(FourSpades);
            deckOfCards.AddCard(FiveSpades);
            deckOfCards.AddCard(SixSpades);
            deckOfCards.AddCard(SevenSpades);
            deckOfCards.AddCard(EightSpades);
            deckOfCards.AddCard(NineSpades);
            deckOfCards.AddCard(TenSpades);
            deckOfCards.AddCard(JackSpades);
            deckOfCards.AddCard(QueenSpades);
            deckOfCards.AddCard(KingSpades);
            return deckOfCards;
        }

        /// <summary>
        /// Prints each card in the deck
        /// </summary>
        /// <param name="deck"></param>
        public static void Print(Deck<Cards> deck)
        {
            foreach(Cards card in deck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuites}");
            }
        }
    }
}
