using System;
using Xunit;
using Lab7_Collection;
using Lab7_Collection.Classes;

namespace TestCollections
{
    public class UnitTest1
    {
        [Fact]
        public void TestDeckCount()
        {
            Deck<Cards> deck = Lab7_Collection.Program.CreateFullDeck();
            int count = deck.GetCount();
            Assert.Equal(52, count);
        }

        [Fact]
        public void TestRemoveCard()
        {
            Deck<Cards> deck = Lab7_Collection.Program.CreateFullDeck();
            bool isTrue = deck.RemoveCard(52);            
            Assert.True(isTrue);
        }

        [Fact]
        public void TestFailedRemoveCard()
        {
            Deck<Cards> deck = Lab7_Collection.Program.CreateFullDeck();
            bool isFalse = deck.RemoveCard(0);
            Assert.False(isFalse);
        }

        [Fact]
        public void TestAddCard()
        {
            Deck<Cards> deck = Lab7_Collection.Program.CreateFullDeck();
            deck.RemoveCard(52);
            Cards KingSpades = new Cards(Number.King, Suites.Spades);
            deck.AddCard(KingSpades);
            int count = deck.GetCount();
            Assert.Equal(52, count);
        }

        
        [Fact]        
        public void TestGetCard()
        {
            Deck<Cards> deck = new Deck<Cards>();
            Cards AceHeart = new Cards(Number.Ace, Suites.Hearts);
            deck.AddCard(AceHeart);
            int count = deck.GetCount();
            Assert.Equal(1, count);
        }
    }
}
