using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 02 - DestroyOutOfBoundX.cs
 * Name: Ka Bo Cheung
 * Date: 02/16/2026
 * Course: GAME-2341-001
 * 
 * Script for the game object to be destroyed once out of the bounds 
 */
public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
