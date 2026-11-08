using UnityEngine;

public class FallBehaviour : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, Random.Range(-1f, -0.5f), 0);
        rb.angularVelocity = new Vector3(Random.Range(1f, -1f), Random.Range(1f, -1f), Random.Range(1f, -1f));
    }

    void Update()
    {
        if(gameObject.transform.position.y < 0)
        {
            Destroy(gameObject);
        }
    }
}
