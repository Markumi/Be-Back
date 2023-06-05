using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    //public float runSpeed = 7f;

    [SerializeField] private Rigidbody _rigidbody;


   // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = player.position + offset;

        //_rigidbody.MovePosition(transform.position + Vector3.forward * runSpeed * Time.deltaTime);
    }

}