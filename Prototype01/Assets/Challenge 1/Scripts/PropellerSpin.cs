using UnityEngine;

/**
 * Challenge 01 - PropellerSpin.cs
 * Name: Ka Bo Cheung
 * Date: 01/26/2026
 * Course: GAME-2341-001
 * 
 * Script for the plane's spinning propeller 
 */
public class PropellerSpin : MonoBehaviour
{
    // Private variables
    private float angle = 0.0f;
    private float rotationSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the propeller by constantly changing z-rotation (not sure if it's accelerating)
        angle += rotationSpeed;
        transform.Rotate(0, 0, angle * Time.deltaTime);
    }
}
