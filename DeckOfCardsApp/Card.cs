using DeckOfCardsApp.Enums;

namespace DeckOfCardsApp;

public class Card
{
    private Suits _suit;
    private Ranks _rank;

    public Card(Suits suit, Ranks rank)
    {
        _suit = suit;
        _rank = rank;
    }

    public override string ToString()
    {
        return _suit + " " + _rank;
    }
}