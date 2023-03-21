using System;

namespace TP2
{
  public class Game
  {
    public const int SPADE = 0;
    public const int CLUB = 1;
    public const int DIAMOND = 2;
    public const int HEART = 3;

    public const int CA = 0;
    public const int C2 = 1;
    public const int C3 = 2;
    public const int C4 = 3;
    public const int C5 = 4;
    public const int C6 = 5;
    public const int C7 = 6;
    public const int C8 = 7;
    public const int C9 = 8;
    public const int C10=9;
    public const int CJ = 10;
    public const int CQ = 11;
    public const int CK = 12;

    public const int HIGH_CARD = 0;
    public const int ONE_PAIR = 1;
    public const int TWO_PAIRS = 2;
    public const int THREE_OF_A_KIND = 3;
    public const int STRAIGHT = 4;
    public const int FLUSH = 5;
    public const int FULL_HOUSE = 6;
    public const int FOUR_OF_A_KIND = 7;
    public const int STRAIGHT_FLUSH = 8;
    public const int ROYAL_FLUSH = 9;

    public const int NUM_SUITS = 4;
    public const int NUM_CARDS_PER_SUIT = 13;
    public const int NUM_CARDS = NUM_SUITS * NUM_CARDS_PER_SUIT;
    public const int NUM_CARDS_IN_HAND = 5;

      public static int GetSuitFromCardIndex(int index)
    {
      // A COMPLETER
      // ...
      // return donné juste pour que ça compile mais valeur incorrecte
      return SPADE;
    }
    public static int GetValueFromCardIndex(int index)
    {
      // A COMPLETER
      // ...
      // return donné juste pour que ça compile mais valeur incorrecte
      return CA;
    }
	
	public static void DrawCards(int[] cardValues, bool[] selectedCards, bool[] availableCards)
    {
      Random random = new Random();
      // A COMPLETER
      // ...

    }

    public static int GetHand(int[] cardValues)
    {
      int hand = HIGH_CARD;
      // A COMPLETER
      // ...
      return hand;
    }

    // A COMPLETER
    // ...
    // Il manque toutes les méthodes pour trouver les paires, les doubles paires, les brelans, etc.
    // Référez-vous aux tests pour les noms de méthodes appropriés.

    public static void ShowHand ( int[] cardValues )
    {
      int hand = GetHand (cardValues);
      Display.WriteString ($"Vous avez actuellement {Display.ConvertHandToString (hand)}", 0, Display.CARD_HEIGHT + 14, ConsoleColor.Black);
    }
  }
}
