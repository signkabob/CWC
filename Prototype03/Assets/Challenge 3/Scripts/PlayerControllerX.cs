using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Challenge 03 - PlayerControllerX.cs
 * Name: Ka Bo Cheung
 * Date: 03/09/2026
 * Course: GAME-2341-001
 * 
 * Script for the player with the animations and sounds
 */
public class PlayerControllerX : MonoBehaviour
{
    public float upperBound = 15.0f;
    public float lowerBound = 1.0f;
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && transform.position.y < upperBound)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }

        // The balloon will stay within the scene and reset its velocity and acceleration
        // if the upper bound is reached
        if (transform.position.y >= upperBound)
        {
            transform.position = new Vector3(transform.position.x, 
                                             Mathf.Clamp(transform.position.y, lowerBound, upperBound),
                                             transform.position.z);
            playerRb.AddForce(Vector3.zero, ForceMode.Acceleration);
            playerRb.angularVelocity = Vector3.zero;
        }
        // The same goes for reaching the lower bound except it will apply a upward force
        // with a sound 
        if (transform.position.y < lowerBound)
        {
            transform.position = new Vector3(transform.position.x,
                                             Mathf.Clamp(transform.position.y, lowerBound, upperBound),
                                             transform.position.z);
            playerRb.AddForce(Vector3.zero, ForceMode.Acceleration);
            playerRb.angularVelocity = Vector3.zero;

            playerAudio.PlayOneShot(bounceSound, 1.0f);
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
