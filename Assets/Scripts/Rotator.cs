using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Declaring variables to easily choose rotation and speed
    public float x = 0; 
    public float y = 0; 
    public float z = 0; 
    public int speed = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x,y,z) * (Time.deltaTime)*speed); // rotate the objects based on public variables
    }
}
