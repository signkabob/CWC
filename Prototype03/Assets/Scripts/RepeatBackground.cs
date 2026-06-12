using UnityEngine;
/**
 * Prototype 03 - RepeatBackground.cs
 * Name: Ka Bo Cheung
 * Date: 03/08/2026
 * Course: GAME-2341-001
 * 
 * Script for the background to loop its translation
 */
public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // If the background reaches the halfway to the left, it is looping back to the starting position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
