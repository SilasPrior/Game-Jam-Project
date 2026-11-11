using UnityEngine;

public class RevolverController : MonoBehaviour
{
    public Cylinder Cylinder;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cylinder = new Cylinder(1);
    }

    public void PullTriger(ISeat who)
    {

        if (Cylinder.Fire())
        {
            Debug.Log($"Shot Live Round at {who.hand.Name}");
        }
        else
        {
            Debug.Log($"Shot Blank Round at {who.hand.Name}");
        }
    }
}
