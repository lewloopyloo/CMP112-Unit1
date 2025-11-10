using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Rigidbody of the player.
    private Rigidbody rb;

    private int scoreCount;

    // Movement along X and Y axes.
    private float movementX;
    private float movementY;

    // Speed at which the player moves.
    public float speed = 0;
    public TextMeshProUGUI countText;


    // Start is called before the first frame update.
    void Start()
    {
        scoreCount = 0;
        // Get and store the Rigidbody component attached to the player.
        rb = GetComponent<Rigidbody>();
        SetCountText();
    }

    // This function is called when a move input is detected.
    void OnMove(InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText() // Function to update the score counter text
    {
        countText.text = "Score: " + scoreCount.ToString(); // Displays "Score: " and the score counter to the screen
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    private void FixedUpdate()
    {
        // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        // Apply force to the Rigidbody to move the player.
        rb.AddForce(movement * speed);



    }

    void OnTriggerEnter(Collider other) // Checking trigger collision
    {
        if (other.gameObject.CompareTag("PickUp")) // If collision is detected with the tag for Pick Ups
        {
            other.gameObject.SetActive(false); // Remove the pick up object
            scoreCount++; // Increment the score counter
            SetCountText(); // Update the text counter for score
        }


    }


}
