using System;
using UnityEngine;

public class DealerController : MonoBehaviour, ISeat
{
    
    public Hand hand { get; set; } = new Hand();
    public bool isStanding { get; set; } = false;

    public event Action<ISeat, BlackjackAction> ActionChosen;

    public Vector3 pos;

    public string Name;

    void Start()
    {
        hand.Position = pos;
        hand.Name = Name;
    }
    public void dealerDecision()
    {
        if (hand.GetWorth() < 17)
        {
            Debug.Log("Dealer hits");
            ActionChosen?.Invoke(this, BlackjackAction.Hit);
        }
        else
        {
            Debug.Log("Dealer stands");
            ActionChosen?.Invoke(this, BlackjackAction.Stand);
        }
    }
}
