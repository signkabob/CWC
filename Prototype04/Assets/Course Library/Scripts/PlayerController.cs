using System.Collections;
using UnityEngine;

/**
 * Prototype 04 - PlayerController.cs
 * Name: Ka Bo Cheung
 * Date: 04/04/2026
 * Course: GAME-2341-001
 * 
 * Script for the player ball controls and force physics along with the powerup function 
 */
public class PlayerController : MonoBehaviour
{
    // Defined global variables
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public GameObject powerupIndicator;

    private float powerupStrength = 15.0f;
    public bool hasPowerup = false;
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        // Move forward based on the camera focal point
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);

        // Hold the powerup indicator position
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    // Trigger checker
    private void OnTriggerEnter(Collider other)
    {
        // If colliding with the powerup, destroy the object and activate the power.
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    // Collision checker
    private void OnCollisionEnter(Collision collision)
    {
        // If the power is activated, the ball knocks the enemy harder once contacted.
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    // The power is only activated for 7 seconds 
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}