using UnityEngine;

public class joyScript : MonoBehaviour
{
    public GameManager gm;
    //public Transform myCamera;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Rigidbody _rigidbody;


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            gm.StopGame();

            Debug.Log("GAME OVER");
        }
    }
}


