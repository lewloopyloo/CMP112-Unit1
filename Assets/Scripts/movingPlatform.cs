using UnityEngine;
using System.Collections;

public class movingPlatform : MonoBehaviour
{

    public GameObject pointA;
    public GameObject pointB;
    public float speed;
    public float delay;
    public GameObject platform;

    private Vector3 targetPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        platform.transform.position = pointA.transform.position;
        targetPos = pointB.transform.position;
        StartCoroutine(movePlat());
    }


    IEnumerator movePlat()
    {
        while (true)
        {
            while ((targetPos - platform.transform.position).sqrMagnitude > 0.01f)
            {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPos, speed * Time.deltaTime);
                yield return null;
            }
            targetPos = targetPos == pointA.transform.position
                ? pointB.transform.position : pointA.transform.position;

            yield return new WaitForSeconds(delay);
        }
    }
}
