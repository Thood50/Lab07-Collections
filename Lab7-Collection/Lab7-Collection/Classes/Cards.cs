using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab7_Collection.Classes
{
    public enum Number
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum Suites
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }


    public class Cards
    {
        public Number CardNumber { get; set; }

        public Suites CardSuites { get; set; }


        /// <summary>
        /// Constructor method for each card
        /// </summary>
        /// <param name="cardnumber"></param>
        /// <param name="cardsuites"></param>
        public Cards(Number cardnumber, Suites cardsuites)
        {
            CardNumber = cardnumber;
            CardSuites = cardsuites;
        }
    }
}
