using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject pauseCanvas;

    static public GameManager instanceGameManager;

    private void Awake()
    {
        instanceGameManager = this;
    }

    private void Start()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }


    public void ReturnGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void HomeGame()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1;
    }
}
