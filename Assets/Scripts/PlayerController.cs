using System;
using UnityEngine;

public class PlayerController : MonoBehaviour, ISeat
{
    public Hand hand { get; set; } = new Hand();
    public bool isStanding { get; set; } = false;

    public event Action<ISeat, BlackjackAction> ActionChosen;

    public Vector3 pos;

    void Start()
    {
        hand.Position = pos;

    }
    public void OnClickHit() 
    {
        ActionChosen?.Invoke(this, BlackjackAction.Hit);

    }
    public void OnClickStand() 
    {
        ActionChosen?.Invoke(this, BlackjackAction.Stand);

    }
}
