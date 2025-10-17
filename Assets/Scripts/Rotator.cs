using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float x = 0; public float y = 0; public float z = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x,y,z) * (Time.deltaTime)*6);
    }
}
