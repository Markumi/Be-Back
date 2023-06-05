using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TachController : MonoBehaviour
{
    public Transform myCamera;
    Vector3 firstPoint;
    Vector3 secondPoint;
    float xAngle;
    float yAngle;
    float xAngleTemp;
    float yAngleTemp;

    // Start is called before the first frame update
    void Start()
    {
        yAngle = transform.localRotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches) 
        {
            if (touch.position.x > Screen.width /2 &  touch.phase == TouchPhase.Began) 
            {
                firstPoint = touch.position;
                xAngleTemp = xAngle;
                yAngleTemp = yAngle;
            }
            if (touch.position.x > Screen.width / 2 & touch.phase == TouchPhase.Moved)
            {
                secondPoint = touch.position;
                xAngle = xAngleTemp - (secondPoint.y - firstPoint.y) * 90/Screen.height;
                yAngle = yAngleTemp + (secondPoint.x - firstPoint.x) * 180/Screen.width;
                transform.rotation = Quaternion.Euler(0, yAngle, 0);
                xAngle = Mathf.Clamp(xAngle, -80, 80);
                myCamera.transform.rotation = Quaternion.Euler(xAngle, yAngle, 0);

            }
        }
    }
}
