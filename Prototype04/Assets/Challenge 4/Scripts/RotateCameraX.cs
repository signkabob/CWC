using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 04 - RotateCameraX.cs
 * Name: Ka Bo Cheung
 * Date: 04/04/2026
 * Course: GAME-2341-001
 * 
 * Script for the camera to rotate around the platform
 */
public class RotateCameraX : MonoBehaviour
{
    private float speed = 200;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        transform.position = player.transform.position; // Move focal point with player

    }
}
