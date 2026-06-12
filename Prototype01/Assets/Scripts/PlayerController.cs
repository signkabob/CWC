using UnityEngine;

/**
 * Prototype 01 - PlayerController.cs
 * Name: Ka Bo Cheung
 * Date: 01/25/2026
 * Course: GAME-2341-001
 * 
 * Script for the player's vehicle control 
 */
public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 15.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
