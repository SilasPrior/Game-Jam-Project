using UnityEngine;

public class TheHighPriestess : ITarotCard
{
    public TarotData Data { get; }
    public bool isActive { get; set; }

    public void Activate()
    {

    }

    public void SpinCylinder(RevolverController revolver)
    {
        revolver.Cylinder.SpinCylinder();
    }
}
