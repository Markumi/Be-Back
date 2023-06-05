using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform myCamera;
    public GameManager gm;
   
    public float jumpDownForce;
    public float jumpForce;
    protected bool doJump = false;

    [SerializeField] private Rigidbody _rigidbody;


    private void FixedUpdate() 
    {
       
    }

    //void Update() 
    //{
    //  if (transform.position.z < -14.03f) 
    //{
    //  gm.StopGame();

    //Debug.Log("Конец игры");
    //}
    //}

    public void OnJumpButtonDown()
    {
        _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        doJump = false;
    }
    
    public void OnJumpDown()
    {
        _rigidbody.AddForce(Vector3.down * jumpDownForce, ForceMode.Impulse);

        doJump = false;
    }

    void Start()
    {
        
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
