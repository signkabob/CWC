using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 02 - DetectCollisionsX.cs
 * Name: Ka Bo Cheung
 * Date: 02/16/2026
 * Course: GAME-2341-001
 * 
 * Script for the ball game object to be destroyed once colliding with the dog
 */
public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
