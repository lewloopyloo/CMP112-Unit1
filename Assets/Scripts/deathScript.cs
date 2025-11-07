using UnityEngine;

public class deathScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Vector3 StartingPosition;
    Vector3 StartingForwardPosition;
    public GameObject deathPlane;
    void Start()
    {
        StartingPosition = transform.position;
        StartingForwardPosition = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == deathPlane)
        {
            transform.position = StartingPosition;
            transform.forward = StartingForwardPosition;
        }
    }
}
