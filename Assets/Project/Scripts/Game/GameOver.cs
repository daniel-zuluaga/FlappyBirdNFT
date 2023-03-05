using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject pauseButton;
    public FlappyMove flappyMove;

    public AudioSource audioSource;

    void Start()
    {
        gameOverCanvas.SetActive(false);
    }

    public void GameOverCanvas()
    {
        flappyMove.audioSource.clip = null;
        audioSource.Play();
        pauseButton.SetActive(false);
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

}
