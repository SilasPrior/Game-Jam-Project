using Unity.VisualScripting;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public GameObject cardPrefab;

    public void createCard(CardData data, Hand hand) { 
 
        GameObject instance = Instantiate(cardPrefab);
        CardObject card = instance.GetComponent<CardObject>();
        bool isFaceUp = false;
        if (hand.GetCards().IsUnityNull())
        {
            isFaceUp = true;
        }
        card.Initialize(data, hand, isFaceUp);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
