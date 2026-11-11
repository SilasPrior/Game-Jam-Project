using UnityEngine;

public interface ITarotCard
{
    TarotData Data { get; }
    bool isActive { get; set; }
    public void Activate();
}
