using UnityEngine;

/**
 * Prototype 01 - FollowPlayer.cs
 * Name: Ka Bo Cheung
 * Date: 01/25/2026
 * Course: GAME-2341-001
 * 
 * Script for the main camera to follow the vehicle 
 */
public class FollowPlayer : MonoBehaviour
{
    // Control variables
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
