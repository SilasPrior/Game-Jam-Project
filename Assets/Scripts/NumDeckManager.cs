using UnityEngine;
using System.Collections.Generic;
using TMPro;
using System.Linq;

public class DeckManager : MonoBehaviour
{
    public List<DeckCard> deckCards;

    void Awake()
    {
        deckCards = new List<DeckCard>();

        Texture[] textures = Resources.LoadAll<Texture>("Textures");
        foreach (Texture tex in textures)
        {
            int value = 0;
            char firstChar = tex.name.First();
            if (firstChar == 'A')
            {
                value = 10;
            }
            else if (firstChar == 'B')
            {
                value = 11;
            }
            else if (firstChar == 'C')
            {
                value = 12;
            }
            else
            {
                value = (int)firstChar;
            }

            DeckCard card = new DeckCard(tex.name, tex, value);

            if (value == 12) 
            {
                 card = new DeckCard(tex.name, tex, value, true);
            }

            Debug.Log(card);
            deckCards.Add(card);

        }
    }


    public DeckCard drawDeckCard()
    {
        int randomIndex = Random.Range(0, deckCards.Count);
        DeckCard card = deckCards[randomIndex];
        deckCards.Remove(card);
        return card;
    }
}
