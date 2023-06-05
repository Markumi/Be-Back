using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    public static bool PauseGame;
    public GameObject pauseMenu;
    //public Text scoreText;
    //public int score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }




    public void Resume()
    {
        pauseMenu.SetActive(false);

        PauseGame = false;
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);

        PauseGame = true;

    }
}