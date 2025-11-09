using UnityEngine;

public class deathScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    Vector3 StartingPosition;
    Vector3 StartingForwardPosition;
    public GameObject deathPlane;
    public GameObject deathPos;
    void Start()
    {
        StartingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == deathPos)
        {
            StartingPosition = deathPos.transform.position;
        }

        if (collision.gameObject == deathPlane)
        {
            transform.position = StartingPosition;
        }
       
    }

}
