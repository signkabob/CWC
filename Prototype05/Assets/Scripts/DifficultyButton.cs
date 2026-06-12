using UnityEngine;
using UnityEngine.UI;

/**
 * Prototype 05 - DifficultyButton.cs
 * Name: Ka Bo Cheung
 * Date: 04/06/2026
 * Course: GAME-2341-001
 * 
 * Script for the difficulty button to trigger the game start 
 */
public class DifficultyButton : MonoBehaviour
{
    // global defined variables
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Enter the difficulty into starting the game 
    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
