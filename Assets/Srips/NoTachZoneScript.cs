using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoTachZoneScript : MonoBehaviour
{
    public GameObject ExitButton;
    public GameObject PlayerTwo;
    public GameObject SettingsButton;


    public void NoTachZoneOn()
    {
        SettingsButton.SetActive(false);
    }

    public void NoTachZoneOff()
    {
        SettingsButton.SetActive(true);
    }


    public void NoTachZoneOnOne()
    {
        PlayerTwo.SetActive(false);
    }

    public void NoTachZoneOffTwo()
    {
        PlayerTwo.SetActive(true);
    }
}
