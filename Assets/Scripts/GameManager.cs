using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DeckManager deckManager;

    PlayerController player;
    DealerController dealer;
    void Start()
    {
        Debug.Log("Game started");
    }
    public void nextTurn(ISeat who, BlackjackAction action)
    {
        if (action == BlackjackAction.Hit)
        {
            DeckCard card = deckManager.drawDeckCard();
            who.hand.addCard(card);
            Debug.Log(who.hand.GetWorth());
        }
        else if (action == BlackjackAction.Stand)
        {
            who.isStanding = true;
            Debug.Log("Next turn " + who.hand.GetWorth());
            who.hand = new Hand();
        }
        
    }
}
