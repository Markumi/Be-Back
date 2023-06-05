using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour



{
    // Start is called before the first frame update
    void Start()
    {
       gameObject.SetActive(Audio_On); 
    }

    public static bool Audio_On = true;

    public void AudioChanger(bool A) 
    {
        Audio_On = A;

        gameObject.SetActive(Audio_On);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
