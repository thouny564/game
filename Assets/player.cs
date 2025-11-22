using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 3.5f;
    private float xInput;
    private float jumpForce = 8;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
        rb.linearVelocity = new Vector2(xInput, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(rb.linearVelocity.y);
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }

    }
}
