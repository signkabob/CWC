using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 01 - FollowPlayerX.cs
 * Name: Ka Bo Cheung
 * Date: 01/26/2026
 * Course: GAME-2341-001
 * 
 * Script for the main camera to follow the plane 
 */
public class FollowPlayerX : MonoBehaviour
{
    // Control variables
    public GameObject plane;
    private Vector3 offset = new Vector3(15,0,0);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Offset the camera on the rightside of the plane by adding to the player's position
        transform.position = plane.transform.position + offset;
    }
}
