using DeckOfCardsApp.Enums;

namespace DeckOfCardsApp;

public class Deck
{
    private const int CountOfCards = 52;
    private Card[] _cards;
    private int _currentCardIndex;
    private readonly Random _randomNumberGen;

    public Deck()
    {
        _cards = new Card[CountOfCards];
        _randomNumberGen = new Random();
        SetupGame();
    }

    public string DealOneCard()
    {
        return _currentCardIndex >= 52 ? "No cards left, so no card" : _cards[_currentCardIndex++].ToString();
    }

    public void Shuffle()
    {
        for (var i = _currentCardIndex; i < CountOfCards; i++)
        {
            var index1 = _randomNumberGen.Next(_currentCardIndex, CountOfCards);
            var index2 = _randomNumberGen.Next(_currentCardIndex, CountOfCards);

            (_cards[index1], _cards[index2]) = (_cards[index2], _cards[index1]);
        }
    }

    public void Restart()
    {
        SetupGame();
    }

    private void SetupGame()
    {
        _currentCardIndex = 0;
        var index = 0;
        for (var i = 0; i < Enum.GetNames(typeof(Suits)).Length; i++)
        {
            for (var j = 0; j < Enum.GetNames(typeof(Ranks)).Length; j++)
            {
                _cards[index++] = new Card((Suits)i, (Ranks)j);
            }
        }

        Shuffle();
    }

    public int CardsCountInDeck()
    {
        return CountOfCards - _currentCardIndex;
    }
}