using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject pauseCanvas;
    public FlappyMove flappyMove;
    public AudioClip audioJumpFlappy;

    static public GameManager instanceGameManager;

    private void Awake()
    {
        instanceGameManager = this;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    private void Start()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }


    public void ReturnGame(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        flappyMove.audioSource.clip = null;
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        flappyMove.audioSource.clip = audioJumpFlappy;
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void HomeGame()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
