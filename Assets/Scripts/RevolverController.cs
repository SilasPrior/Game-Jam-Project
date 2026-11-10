using UnityEngine;

public class RevolverController : MonoBehaviour
{
    private Cylinder _cylinder;  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cylinder = new Cylinder(1);
    }

    public void PullTriger(ISeat who)
    {

        if (_cylinder.Fire())
        {
            Debug.Log($"Shot Live Round at {who.hand.Name}");
        }
        else
        {
            Debug.Log($"Shot Blank Round at {who.hand.Name}");
        }
    }
}
