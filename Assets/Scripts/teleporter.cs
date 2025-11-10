using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class teleporter : MonoBehaviour
{

    public Transform teleportTarget;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Detecting Collision
    {
        if (other.gameObject.CompareTag("Player")) // If the object collides with the player tagg
        {
            player.transform.position = teleportTarget.transform.position; // Teleport the player to the teleport targets position
        }

    }
}
