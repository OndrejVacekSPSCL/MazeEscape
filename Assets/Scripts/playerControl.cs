using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float movementSpeed;
    float speedX, speedY;
    Rigidbody2D rigidBody;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
    public void ChangeMovementSpeed(float value)
    {
        movementSpeed = value;
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movementSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movementSpeed;
        rigidBody.linearVelocity = new Vector2(speedX, speedY);

        animator.SetFloat("XInput", speedX);
        animator.SetFloat("YInput", speedY);

        // You could also add a check for movement direction or idle state if needed
        if (speedX != 0 || speedY != 0)
        {
            animator.SetBool("IsWalking", true);  
        }
        else
        {
            animator.SetBool("IsWalking", false); // No movement, set idle
        }
    }
}
