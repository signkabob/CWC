using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 02 - PlayerControllerX.cs
 * Name: Ka Bo Cheung
 * Date: 02/16/2026
 * Course: GAME-2341-001
 * 
 * Script for the player to spawn the running dog
 */
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 2.0f;
    private float nextActionTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Only can send the dog again 2 seconds after last spawn
            if (Time.time > nextActionTime)
            {
                nextActionTime = Time.time + cooldownTime;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
