using UnityEngine;

/**
 * Prototype 04 - RotateCamera.cs
 * Name: Ka Bo Cheung
 * Date: 04/04/2026
 * Course: GAME-2341-001
 * 
 * Script for the camera to rotate around the platform
 */
public class RotateCamera : MonoBehaviour
{
    // Defined global variable
    public float rotationSpeed = 50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
