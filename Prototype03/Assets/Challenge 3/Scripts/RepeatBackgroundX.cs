using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 03 - RepeatBackgroundX.cs
 * Name: Ka Bo Cheung
 * Date: 03/09/2026
 * Course: GAME-2341-001
 * 
 * Script for the background to loop its translation
 */
public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


