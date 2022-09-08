using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    static int _score = 0;

    bool _isGameOver = false;

    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;

    public static GameState Instance;

    void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && _isGameOver)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void IncreaseScore(int amount)
    {
        _score += amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;
    }

    public void InitiateGameOver()
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);
    }
}
