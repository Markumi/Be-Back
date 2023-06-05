using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Shot;
    public GameObject music;
    public GameObject StopBut;
    public GameObject AndGamePanel;
    public PlayerMovement movement;
    //public float levelRestartDelay = 0.10f;

    public void StopGame()
    {
        movement.enabled = false;

        music.SetActive(false);

        //Invoke("RestartLevel", levelRestartDelay);


        Shot.SetActive(false);

        Time.timeScale = 0f;

        AndGamePanel.SetActive(true);

        StopBut.SetActive(false);
    }
    void OnJumpButtonDownRestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


