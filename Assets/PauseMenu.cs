
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{ 
    public GameObject PlayButton;
    public GameObject Sanki;
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
        pauseMenu.SetActive(true);
        Time.timeScale = 1f;
        //ScoreManager.score = Time.timeScale;
        //PauseGame = false;
    }

    public void VeborSaney() 
    {
        PlayButton.SetActive(false);
        Sanki.SetActive(true);
    }
     
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;

    }

    public void PauseNoTime()
    {
        pauseMenu.SetActive(true);
        PauseGame = true;

    }

    public void OnJumpButtonDownRestarLevel() 
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

       Time.timeScale = 1;
    }


    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }


}