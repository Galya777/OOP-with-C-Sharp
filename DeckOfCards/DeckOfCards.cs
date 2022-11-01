// Fig. 8.10: DeckOfCards.cs
// DeckOfCards class represents a deck of playing cards.
using System;

public class DeckOfCards
{
   private Card[] deck; // array of Card objects
   private int currentCard; // index of next Card to be dealt
   public const int NUMBER_OF_CARDS = 52; // constant number of Cards
   private Random randomNumbers; // random number generator

    private int[] faceCounters;
    private int[] suitCounters;
    private Card[] hand;
   // constructor fills deck of Cards
   public DeckOfCards()
   {

        hand = new Card[5];
        faceCounters = new int[Card.faces.Length];
        suitCounters = new int[Card.suits.Length];
        deck = new Card[ NUMBER_OF_CARDS ]; // create array of Card objects
      currentCard = 0; // set currentCard so deck[ 0 ] is dealt first  
      randomNumbers = new Random(); // create random number generator

      // populate deck with Card objects
      for ( int count = 0; count < deck.Length; count++ )
         deck[ count ] =
            new Card( count % 13 ,  count / 13  );
   } // end DeckOfCards constructor

   // shuffle deck of Cards with one-pass algorithm
   public void Shuffle()
   {
      // after shuffling, dealing should start at deck[ 0 ] again
      currentCard = 0; // reinitialize currentCard

      // for each Card, pick another random Card and swap them
      for ( int first = 0; first < deck.Length; first++ )
      {
         // select a random number between 0 and 51 
         int second = randomNumbers.Next( NUMBER_OF_CARDS );

         // swap current Card with randomly selected Card
         Card temp = deck[ first ];
         deck[ first ] = deck[ second ];
         deck[ second ] = temp;
      } // end for
   } // end method Shuffle

   // deal one Card
   public Card DealCard()
   {
      // determine whether Cards remain to be dealt
      if ( currentCard < deck.Length )
         return deck[ currentCard++ ]; // return current Card in array
      else
         return null; // indicate that all Cards were dealt
   } // end method DealCard
} // end class DeckOfCards
public void DealHand()
{
    for(int i = 0; i < faceCounters.Length; ++i)
    {
        faceCounters[i] = 0;
    }
    for (int i = 0; i < suitCounters.Length; ++i)
    {
        suitCounters[i] = 0;
    }
    for (int i = 0; i < hand.Length; ++i)
    {
       hand[i] = DealCard();
    }
    MakeStatistics();
}
private void MakeStatistics()
{
    for (int i = 0; i < hand.Length; ++i)
    {
        if (hand[i] != null)
        {
            ++faceCounters[hand[i].Face];
            ++suitCounters[hand[i].Suit];
        }
    }
}
private bool HasSequence(int count)
{
    int countFound = 0;
    bool seqStart = false;
    for (int i = 0; i < faceCounters.Length; i++)
    {
        if (faceCounters[i] >= 1 && seqStart)
        {
            countFound++;
            if (countFound == count) return true;
        }
        if (faceCounters[i] == 0)
        {
            countFound = 0;
            seqStart = false;
        }
        if (faceCounters[i] >= 1 && !seqStart)
        {
            countFound = 1;
            seqStart = true;
                }
    }
    return seqStart;
}
public bool Has2Plus2Faces()
{
    bool first2Found = false;
    for (int i = 0; i < hand.Length; ++i)
    {

    }
    }
public bool Has2Faces(int faceNumber)
{
    for (int i = 0; i < faceCounters.Length; ++i)
    {
        if (faceCounters[i] == faceNumber) return true;
    }
    return false;
}
}
private void PrintHand()
{
    for(int i = 0; i < hand.Length; ++i)
    {
        if (hand[i] != null)
        {
            Console.WriteLine(hand[i] + ',');
        }
    }
    Console.WriteLine(hand[hand.Length - 1]);
}

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
