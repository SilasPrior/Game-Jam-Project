using UnityEngine;

public class DealerController : MonoBehaviour, ISeat
{
    
    public Hand hand { get; set; } = new Hand();
    public bool isStanding { get; set; } = false;

    void dealerDecision()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (hand.GetWorth() < 17)
        {
            Debug.Log("Dealer hits");
            gameManager.nextTurn(this, BlackjackAction.Hit);
        }
        else
        {
            Debug.Log("Dealer stands");
            gameManager.nextTurn(this, BlackjackAction.Stand);
        }
    }
}
