using Unity.VisualScripting;
using UnityEngine;

/**
 * Prototype 04 - Enemy.cs
 * Name: Ka Bo Cheung
 * Date: 04/04/2026
 * Course: GAME-2341-001
 * 
 * Script for the enemy ball that moves toward the player
 */
public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Move toward the player position
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
        
        // Destroy the ball object once fallen
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
