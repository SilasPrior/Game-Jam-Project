using UnityEngine;

public class SpawnFallers : MonoBehaviour
{
    public GameObject[] Faller;
    int wait = 0;

    void FixedUpdate()
    {

        if(wait <= 0)
        {
            Instantiate(Faller[Random.Range(0, Faller.Length)], new Vector3(transform.position.x + Random.Range(1f, -1f), transform.position.y + Random.Range(0.5f, -0.5f), transform.position.z + Random.Range(1f, -1f)), Quaternion.identity);

            wait = Random.Range(120, 150);
        }

        wait--;
    }
}
