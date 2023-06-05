using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public int scoree;
    public int scoreee;

    public float time;
    private float timeStart;


    public float timee;
    private float timeStaart;

    public float timeee;
    private float timeStaaart;
    //public PlayerMovement pm;



    void Update() 
    {    
        time -= Time.deltaTime;
        if (time <= 0)
        {
            ScoreManager.score += 1;

            time = timeStart;
        }

        timee -= Time.deltaTime;
        if (timee <= 0)
        {
            ScoreManager.scoree += 1;

            timee = timeStaart;
        }

        timeee -= Time.deltaTime;
        if (timeee <= 0)
        {
           ScoreManager.scoreee += 1;

           timeee = timeStaaart; 
        }
    }


   // void Update()
   // {
    //    ScoreManager.score = 1;
    //    else 
    //    {
    //       pm.OmJumpButtonDown();
    //    }  
    //}
}
