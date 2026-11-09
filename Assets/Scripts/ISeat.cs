using System;
using System.Numerics;

public interface ISeat
{
    Hand hand { get; set; } 
    bool isStanding { get; set; }

    event Action<ISeat, BlackjackAction> ActionChosen;

}