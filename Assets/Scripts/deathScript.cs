using UnityEngine;

public class deathScript : MonoBehaviour
{


    Vector3 StartingPosition;  // Declaring variables
    public GameObject deathPlane; 
    public GameObject deathPos; 
    public GameObject deathPos2;
    void Start()
    {
        StartingPosition = transform.position; // Sets starting position to teleport the player back when colliding with death plane
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider collision) // Collision check
    {
        if (collision.gameObject == deathPos2)
        {
            StartingPosition = deathPos2.transform.position; // sets start position to teleport the player to the beginning of level 3 rather than the beginning of levels 1 or 2
        }

        else if (collision.gameObject == deathPos) // If colliding with the 'deathPos' object
        {
            StartingPosition = deathPos.transform.position; // sets start position to teleport the player to the beginning of level 2 rather than the beginning of level 1
        }

        else if (collision.gameObject == deathPlane) // If colliding with the death plane
        {
            transform.position = StartingPosition; // sets players position to 'StartingPosition' which could be at the start of any of the levels 
        }
       
    }

}
