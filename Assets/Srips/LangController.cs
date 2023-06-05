using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangController : MonoBehaviour
{
    public static bool Is_English = true;

    public void EngChanger(bool A)
    {
        Is_English = A;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
