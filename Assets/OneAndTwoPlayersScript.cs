using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OneAndTwoPlayersScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {     
        gameObject.SetActive(Player_On);
    }

    public static bool Player_Off = false;
    public static bool Player_On = true;

    public void OnePlayerInGame(bool A)
    {
        Player_On = A;

        gameObject.SetActive(Player_On);
    }

    public void TwoPlayerInGame(bool B)
    {
        Player_On = B;
        gameObject.SetActive(Player_Off);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
