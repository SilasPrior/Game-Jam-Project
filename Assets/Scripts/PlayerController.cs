using System;
using UnityEngine;

public class PlayerController : MonoBehaviour, ISeat
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
    public void OnClickHit() 
    {
        if (hand.GetWorth() >= 21)
        {
            Debug.Log("Player cannot hit, hand is already 21 or more.");
            return;
        }
        ActionChosen?.Invoke(this, BlackjackAction.Hit);

    }
    public void OnClickStand() 
    {
        ActionChosen?.Invoke(this, BlackjackAction.Stand);

    }
}
