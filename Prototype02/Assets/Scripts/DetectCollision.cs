using UnityEngine;

/**
 * Prototype 02 - DetectCollision.cs
 * Name: Ka Bo Cheung
 * Date: 02/16/2026
 * Course: GAME-2341-001
 * 
 * Script for the animal game object to be destroyed once collising with the projectile 
 */
public class DetectCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
