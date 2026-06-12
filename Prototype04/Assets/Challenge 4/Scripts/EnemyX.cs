using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 04 - EnemyX.cs
 * Name: Ka Bo Cheung
 * Date: 04/04/2026
 * Course: GAME-2341-001
 * 
 * Script for the enemy ball that moves toward the player
 */
public class EnemyX : MonoBehaviour
{
    public float speed = 30.0f;
    private Rigidbody enemyRb;
    private GameObject playerGoal;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal");

        // Refer to spawn manager speedUp variable
        speed += GameObject.Find("Spawn Manager").GetComponent<SpawnManagerX>().speedUp;
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }
}
