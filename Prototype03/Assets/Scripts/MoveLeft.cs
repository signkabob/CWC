using UnityEngine;

/**
 * Prototype 03 - MoveLeft.cs
 * Name: Ka Bo Cheung
 * Date: 03/08/2026
 * Course: GAME-2341-001
 * 
 * Script for moving the object to the left
 */
public class MoveLeft : MonoBehaviour
{   
    // Defined global variables
    private float speed = 30;
    private float leftBound = -15;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the game is not over yet, the object continue to move left
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // If the object is out of bound, it is destroyed
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
