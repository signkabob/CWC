using UnityEngine;

/**
 * Prototype 02 - DestroyOutOfBound.cs
 * Name: Ka Bo Cheung
 * Date: 02/16/2026
 * Course: GAME-2341-001
 * 
 * Script for the game object to be destroyed once out of the bounds 
 */
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
