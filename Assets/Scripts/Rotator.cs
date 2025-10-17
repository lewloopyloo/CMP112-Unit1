using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    float degreesPerSecond = 20;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -degreesPerSecond) * (Time.deltaTime)*6);
    }
}
