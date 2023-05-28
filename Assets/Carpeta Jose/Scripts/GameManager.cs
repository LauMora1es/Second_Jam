using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGamePaused = false;
    public GameObject CanvasPause;
    private MyData myData;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void startGame()
    {
        SceneManager.LoadScene("Juego UI-002");
        //Time.timeScale = 1f;
    }

    private void TogglePause()
    {
        isGamePaused = !isGamePaused;

        if (isGamePaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Juego pausado");
            CanvasPause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("Juego reanudado");
            CanvasPause.SetActive(false);

        }
    }

}
