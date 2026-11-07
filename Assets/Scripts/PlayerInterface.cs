using UnityEngine;


public class PlayerController : MonoBehaviour, ISeat
{
    public Hand hand { get; set; } = new Hand();
    public bool isStanding { get; set; } = false;

    public void OnClickHit() 
    {         
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.nextTurn(this, BlackjackAction.Hit);
    }
    public void OnClickStand() 
    {         
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.nextTurn(this, BlackjackAction.Stand);
    }
}
