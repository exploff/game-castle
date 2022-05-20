using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    private bool canMove = true;

    public Rigidbody2D rigidbody2D;
    public Animator animator;

    Vector2 movement;

    public void ManageMovement() {

        this.canMove = this.canMove ? false : true;
    }

    //called once per frame
    void Update()
    {
        // Input
        if (canMove) {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }
    

    //execute on a fixed time
    void FixedUpdate()
    {
        // Movement
        if(canMove) {
            rigidbody2D.MovePosition(rigidbody2D.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);

        }
    
    }
    

    void Start()
    {
        
    }

   
}
