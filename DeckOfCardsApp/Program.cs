// See https://aka.ms/new-console-template for more information

using DeckOfCardsApp;

Console.WriteLine();
Console.WriteLine("  <<<   DECK OF CARDS APP FOR AMS GEEK   >>>     ");
Console.WriteLine();
Console.WriteLine("           Press Enter to start game!            ");
Console.WriteLine();
Console.WriteLine();

if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    Deck deck = Deck.GetInstance;

    Console.WriteLine("                      Please enter a number to continue:                ");
    Console.WriteLine();
    Console.WriteLine("Deal a Card          Cards count in deck         Shuffle         Restart");
    Console.WriteLine("     1                        2                     3               4   ");
    Console.WriteLine();

    while (true)
    {
        var inputValue = Console.ReadLine();

        switch (inputValue)
        {
            case "1":
                Console.WriteLine($"'{deck.DealOneCard()}' is dealt");
                break;
            case "2":
                Console.WriteLine($"{deck.CardsCountInDeck()} card(s) left in the deck");
                break;
            case "3":
                if(deck.CardsCountInDeck() == 0)
                    Console.WriteLine("Nothing to shuffle");
                else
                {
                    deck.Shuffle();
                    Console.WriteLine("Cards are shuffled");
                }
                break;
            case "4":
                deck.Restart();
                Console.WriteLine("New Game started");
                break;
            default:
                Console.WriteLine("Please, enter a number, not any other character");
                break;
        }
    }
}