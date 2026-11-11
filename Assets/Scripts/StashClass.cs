using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StashClass
{
    private List<ITarotCard> _cards = new();

    public List<ITarotCard> GetCards()
    {
        return _cards;
    }
    public void AddCard(ITarotCard card)
    {
        _cards.Add(card);
    }
    public void RemoveCard(ITarotCard card)
    {
        _cards.Remove(card);
    }
    public void ClearStash()
    {
        _cards.Clear();
    }
}
