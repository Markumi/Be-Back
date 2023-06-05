
using UnityEngine;


public class ChanksFollow : MonoBehaviour
{
    public float runSpeed = -7f;
    [SerializeField] private Rigidbody _rigidbody;


    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + Vector3.forward * runSpeed * Time.deltaTime);
    }
}
