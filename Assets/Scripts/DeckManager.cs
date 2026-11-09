using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class DeckManager : MonoBehaviour
{
    [SerializeField]
    public List<CardData> deckCards;
    public CardSpawner cardSpawner;

    void Awake()
    {
        restartDeck();
    }

    public void restartDeck()
    {
        deckCards = new List<CardData>();
        deckCards = Resources.LoadAll<CardData>("Blackjack/Cards").ToList();
    }

    public CardData drawDeckCard(Hand hand)
    {
        if (deckCards.Count == 0) 
        { 
            Debug.LogWarning("Deck empty, reshuffling");
            restartDeck();
        }
        int randomIndex = Random.Range(0, deckCards.Count);
        CardData card = deckCards[randomIndex];
        cardSpawner.createCard(card, hand);
        deckCards.Remove(card);
        return card;
    }
}
