using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 01 - PlayerControllerX.cs
 * Name: Ka Bo Cheung
 * Date: 01/26/2026
 * Course: GAME-2341-001
 * 
 * Script for the player's plane control 
 */
public class PlayerControllerX : MonoBehaviour
{
    // Private variables
    private float speed = 10f;
    private float rotationSpeed = 50.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Tilt the plane up/down based on up/down arrow keys;
        // Change vector.left to vector.right for correct tilting direction
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
