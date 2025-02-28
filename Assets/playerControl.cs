using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float movementSpeed;
    float speedX, speedY;
    Rigidbody2D rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movementSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movementSpeed;
        rigidBody.linearVelocity = new Vector2(speedX, speedY);
    }
}
