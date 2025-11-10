using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour
{
    // Declaring variables
    public GameObject pointA;
    public GameObject pointB;
    public float speed;
    public float delay;
    public GameObject platform;

    private Vector3 targetPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platform.transform.position = pointA.transform.position; // the moving platform starts at point A's position
        targetPos = pointB.transform.position; // target position is set to Point B's position
        StartCoroutine(movePlat()); // Coroutine to move the platform is started
    }


    IEnumerator movePlat()
    {
        while (true)
        {
            while ((targetPos - platform.transform.position).sqrMagnitude > 0.01f) // While the platform is not currently at the target Position
            {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPos, speed * Time.deltaTime); // move the platform towards the target Position
                yield return null;
            }
            targetPos = targetPos == pointA.transform.position // switch target Position to Point A's position
                ? pointB.transform.position : pointA.transform.position;

            yield return new WaitForSeconds(delay);
        }
    }
}
