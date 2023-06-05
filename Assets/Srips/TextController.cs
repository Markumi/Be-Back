using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (LangController.Is_English) 
        {
            GetComponent<TMP_Text>().text = On_English;
        }
        else{GetComponent<TMP_Text>().text = On_Russian;} 
    }

    public string On_English;

    public string On_Russian;

    // Update is called once per frame
    void Update()
    {
        
    }
}
