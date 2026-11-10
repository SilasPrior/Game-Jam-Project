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

    public CardObject drawDeckCard(Hand hand)
    {
        if (deckCards.Count == 0) 
        { 
            Debug.LogWarning("Deck empty, reshuffling");
            restartDeck();
        }
        int randomIndex = Random.Range(0, deckCards.Count);
        CardData cardData = deckCards[randomIndex];
        CardObject card = cardSpawner.createCard(cardData, hand);
        deckCards.Remove(cardData);
        return card;
    }
}
