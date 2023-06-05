using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text Highscoree;
    [SerializeField] Text HighscoreText;

    [SerializeField] Text ScoreeeText;
    [SerializeField] Text ScoreeText;
    [SerializeField] Text ScoreText;

    public static float scoreee;
    public static float scoree;
    public static float score;

    int highscore;
    int highscoree;
    int highscoreee;

    void Start()
    {
        score = 0;

        scoree = 0;

        scoreee = 0;
    }

    void Update()
    {
        highscore = (int)score;
        ScoreText.text = "" + highscore.ToString();

        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
        }
        HighscoreText.text = "" + PlayerPrefs.GetInt("score").ToString();

        highscoree = (int)scoree;
        ScoreeText.text = "" + highscoree.ToString();

        if (PlayerPrefs.GetInt("scoree") <= highscoree)
        {
            PlayerPrefs.SetInt("scoree", highscoree);
        }
        Highscoree.text = "" + PlayerPrefs.GetInt("scoree").ToString();

        highscoreee = (int)scoreee;
        ScoreeeText.text = "" + highscoreee.ToString();

        if (PlayerPrefs.GetInt("scoreee") <= highscoreee)
        {
            PlayerPrefs.SetInt("scoreee", highscoreee);
        }
    }

}
