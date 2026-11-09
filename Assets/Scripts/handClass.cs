using System.Collections.Generic;
using UnityEngine;

public class Hand 
{
    private List<CardData> cards = new List<CardData>();

    public Vector3 Position { get; set; }

    public void addCard(CardData card) => cards.Add(card);

    public List<CardData> GetCards() => cards;

    public void ClearHand() => cards.Clear();
    public int GetWorth()
    {
        int total = 0;
        int aces = 0;

        foreach (CardData card in cards)
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
