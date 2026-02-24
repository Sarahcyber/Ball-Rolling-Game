using UnityEngine;

public class BallController : MonoBehaviour
{
    public float rollSpeed = 5f;
    public float jumpForce = 7f;
    private bool isGrounded = true;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // auto roll forward every physics frame
        rb.linearVelocity = new Vector3(0f, rb.linearVelocity.y, rollSpeed);
    }
    // called by the UI Button OnClick event
    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") ||
            collision.gameObject.CompareTag("Obstacle"))
        {
            isGrounded = true;
        }
    }
}



