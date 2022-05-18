using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rigidbody2D;
    public Animator animator;

    Vector2 movement;

    //called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    //execute on a fixed time
    void FixedUpdate()
    {
        // Movement
        rigidbody2D.MovePosition(rigidbody2D.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    
    }
    

    void Start()
    {
        
    }

   
}
