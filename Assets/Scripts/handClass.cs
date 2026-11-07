using System.Collections.Generic;


public class Hand 
{
    private List<DeckCard> cards = new List<DeckCard>();

    public void addCard(DeckCard card) => cards.Add(card);

    public int GetWorth()
    {
        int total = 0;
        int aces = 0;

        foreach (DeckCard card in cards)
        {
            total += card.Value;          
            if (card.IsAce) aces++;
        }

        while (total > 21 && aces > 0)
        {
            total -= 10;
            aces--;
        }

        return total;
    }

}
