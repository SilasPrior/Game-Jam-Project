using UnityEngine;
using System.Collections.Generic;

public class DeckManager : MonoBehaviour
{
    public List<DeckCard> deckCards;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    DeckCard drawDeckCard()
    {
        int randomIndex = Random.Range(0, deckCards.Count);
        DeckCard card = deckCards[randomIndex];
        deckCards.Remove(card);
        return deckCards[randomIndex];
    }
}
