using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChanks : MonoBehaviour
{ 
   private CharacterController controller;
   public Vector3 dir;




    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(dir * Time.fixedDeltaTime);
    }
}
