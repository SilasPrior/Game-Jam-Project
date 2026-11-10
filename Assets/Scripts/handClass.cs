using System.Collections.Generic;
using UnityEngine;

public class Hand 
{
    private List<CardObject> cards = new List<CardObject>();

    public string Name { get; set; }

    public Vector3 Position { get; set; }

    public void addCard(CardObject card) => cards.Add(card);

    public List<CardObject> GetCards() => cards;

    public void ClearHand() => cards.Clear();
    public int GetWorth()
    {
        int total = 0;
        int aces = 0;

        foreach (CardObject card in cards)
        {
            total += card.cardData.Value;          
            if (card.cardData.IsAce) aces++;
        }

        while (total > 21 && aces > 0)
        {
            total -= 10;
            aces--;
        }

        return total;
    }

}
