using System;
using System.Collections.Generic;

namespace assignment4_BlackJack
{
    class Program
    {
        // Create a greeting and playing instructions
        static void DisplayGreeting()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine(" Welcome to the BlackJack game!");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine(" The object of the game is to beat the dealer's hand without going over 21.");
            Console.WriteLine(" Face cards are worth their stated value. Kings, Queens, and Jacks are worth 10. Aces are worth 11.");
            Console.WriteLine(" Each player starts with two cards, but the dealer's cards are hidden until the end.");
            Console.WriteLine(" Either 'Hit' to ask for another card, or Stand to hold your total and end your turn.");
            Console.WriteLine(" If you go over 21 you bust, and the dealer wins regardless of the dealer's hand.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
        // Card class
        public class Card
        {
            public string Face { get; set; }
            public string Suit { get; set; }

            public int Value()
            {
                int cardVal = 0;

                if (Face == "Ace")
                {
                    cardVal = 11;
                }
                else if ((Face == "King") || (Face == "Queen") || (Face == "Jack") || (Face == "Ten"))
                {
                    cardVal = 10;
                }
                else
                {
                    switch (Face)
                    {
                        case "Two":
                            cardVal = 2;
                            break;

                        case "Three":
                            cardVal = 3;
                            break;

                        case "Four":
                            cardVal = 4;
                            break;

                        case "Five":
                            cardVal = 5;
                            break;

                        case "Six":
                            cardVal = 6;
                            break;

                        case "Seven":
                            cardVal = 7;
                            break;

                        case "Eight":
                            cardVal = 8;
                            break;

                        case "Nine":
                            cardVal = 9;
                            break;
                    }

                }
                return cardVal;

            }

            static void Main(string[] args)
            {

                string playAgain = "Y";
                while (playAgain == "Y")
                {

                    DisplayGreeting();

                    // Create card deck
                    var cardFace = new List<string>();
                    var cardSuit = new List<string>();

                    cardFace.Add("Two");
                    cardFace.Add("Three");
                    cardFace.Add("Four");
                    cardFace.Add("Five");
                    cardFace.Add("Six");
                    cardFace.Add("Seven");
                    cardFace.Add("Eight");
                    cardFace.Add("Nine");
                    cardFace.Add("Ten");
                    cardFace.Add("Jack");
                    cardFace.Add("Queen");
                    cardFace.Add("King");
                    cardFace.Add("Ace");

                    cardSuit.Add(" of Diamonds");
                    cardSuit.Add("of Spade");
                    cardSuit.Add(" of Hearts");
                    cardSuit.Add(" of Clubs");

                    List<Card> cardDeck = new List<Card>();
                    List<Card> playingCard = new List<Card>();

                    cardDeck.Add(new Card() { Face = "Two", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Three", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Four", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Five", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Six", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Seven", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Eight", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Nine", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Ten", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Jack", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Queen", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "King", Suit = " of Diamonds" });
                    cardDeck.Add(new Card() { Face = "Ace", Suit = " of Diamonds" });

                    cardDeck.Add(new Card() { Face = "Two", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Three", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Four", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Five", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Six", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Seven", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Eight", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Nine", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Ten", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Jack", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Queen", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "King", Suit = " of Spades" });
                    cardDeck.Add(new Card() { Face = "Ace", Suit = " of Spades" });

                    cardDeck.Add(new Card() { Face = "Two", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Three", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Four", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Five", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Six", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Seven", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Eight", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Nine", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Ten", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Jack", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Queen", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "King", Suit = " of Hearts" });
                    cardDeck.Add(new Card() { Face = "Ace", Suit = " of Hearts" });

                    cardDeck.Add(new Card() { Face = "Two", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Three", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Four", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Five", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Six", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Seven", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Eight", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Nine", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Ten", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Jack", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Queen", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "King", Suit = " of Clubs" });
                    cardDeck.Add(new Card() { Face = "Ace", Suit = " of Clubs" });


                    // Establish variables used for shuffling
                    Random rnd = new Random();
                    List<Card> tempVar = new List<Card>();
                    tempVar.Add(new Card() { Face = "NaN", Suit = "NaN" });
                    int firstIndex;
                    int secondIndex;

                    // Shuffle cards using the Fisher-Yates Algorithm
                    for (var number = cardDeck.Count - 1; number >= 0; --number)
                    {
                        firstIndex = number;
                        secondIndex = rnd.Next(0, firstIndex);
                        tempVar[0].Face = cardDeck[firstIndex].Face;
                        tempVar[0].Suit = cardDeck[firstIndex].Suit;
                        cardDeck[firstIndex].Face = cardDeck[secondIndex].Face;
                        cardDeck[firstIndex].Suit = cardDeck[secondIndex].Suit;
                        cardDeck[secondIndex].Face = tempVar[0].Face;
                        cardDeck[secondIndex].Suit = tempVar[0].Suit;
                    }

                    // Start the game
                    int counter = 0;
                    string playerCard1 = cardDeck[counter].Face + cardDeck[counter].Suit;
                    string playerCard2 = cardDeck[++counter].Face + cardDeck[counter].Suit;
                    string dealerCard1 = cardDeck[++counter].Face + cardDeck[counter].Suit;
                    string dealerCard2 = cardDeck[++counter].Face + cardDeck[counter].Suit;
                    string currentCard = cardDeck[++counter].Face + cardDeck[counter].Suit;
                    List<Card> playerNextCard = new List<Card>();
                    playerNextCard.Add(new Card());
                    List<Card> dealerNextCard = new List<Card>();
                    dealerNextCard.Add(new Card());
                    int playerTotal = cardDeck[0].Value() + cardDeck[1].Value();
                    int dealerTotal = cardDeck[2].Value() + cardDeck[3].Value();

                    // Display player's card and begin the game
                    Console.WriteLine($"Player's first card is {playerCard1}");
                    Console.WriteLine($"Player's second card is {playerCard2}");
                    Console.WriteLine($"Current total for player is {playerTotal}");
                    Console.WriteLine("                                          ");

                    while (playerTotal <= 16)
                    {
                        Console.Write("Type 'H' to hit or 'S' to stand ");
                        string answer = Console.ReadLine();

                        if (answer == "H")
                        {
                            playerTotal = playerTotal + cardDeck[++counter].Value();
                            Console.WriteLine("                                                              ");
                            Console.WriteLine($"New card is {cardDeck[counter].Face + cardDeck[counter].Suit}");
                            Console.WriteLine($"New total is {playerTotal}");
                            if (playerTotal == 21)
                            {
                                Console.WriteLine("Blackjack! Player wins!");
                            }
                            else if (playerTotal > 21)
                            {
                                Console.WriteLine("Busted! Dealer wins.");
                            }
                        }
                        else if (answer == "S")
                        {
                            break;
                        }
                    }

                    // Start dealer's hand
                    if (playerTotal < 21)
                    {
                        Console.WriteLine("                                           ");
                        Console.WriteLine($"Dealer's first card is {dealerCard1}");
                        Console.WriteLine($"Dealer's second card is {dealerCard2}");
                        Console.WriteLine($"Current total for dealer is {dealerTotal}");

                        while (dealerTotal <= 16)
                        {
                            {
                                dealerTotal = dealerTotal + cardDeck[++counter].Value();
                                Console.WriteLine("                                                              ");
                                Console.WriteLine($"New card is {cardDeck[counter].Face + cardDeck[counter].Suit}");
                                Console.WriteLine($"New total is {dealerTotal}");
                                if (dealerTotal == 21)
                                {
                                    Console.WriteLine("Blackjack! Dealer wins");

                                }
                                else if (dealerTotal > 21)
                                {
                                    Console.WriteLine("Busted! Player wins!");

                                }
                            }
                        }
                    }

                    // Display game results
                    if (playerTotal <= 20 && dealerTotal <= 20)
                    {
                        if (playerTotal > dealerTotal)
                        {
                            Console.WriteLine($"Player wins, {playerTotal} - {dealerTotal}!");
                        }
                        else if (dealerTotal > playerTotal)
                        {
                            Console.WriteLine($"Dealer wins, {dealerTotal} - {playerTotal}");
                        }
                        else if (playerTotal == dealerTotal)
                        {
                            Console.WriteLine($"Tie game, {playerTotal} - {dealerTotal}");
                        }
                    }

                    // Ask the player if they wish to play again
                    Console.WriteLine("                            ");
                    Console.Write("Play again? Answer 'Y' or 'N' : ");
                    playAgain = Console.ReadLine();
                }
            }

        }
    }
}