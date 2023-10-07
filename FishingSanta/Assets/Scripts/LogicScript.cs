using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject toy;

    [ContextMenu("Increase Score")]
    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString() + "/20";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void Update()
    {
        if (toy.transform.position.y >= 1.0f)
        {
            AddScore();
        }
    }
}