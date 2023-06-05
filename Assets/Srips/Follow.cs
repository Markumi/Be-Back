
using UnityEngine;


public class Follow : MonoBehaviour
{ 
  public float runSpeed = -17f;
  [SerializeField] private Rigidbody _rigidbody;

 
    private void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + Vector3.forward * runSpeed * Time.deltaTime);
    }
}
