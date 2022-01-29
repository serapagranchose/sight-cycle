using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private LayerMask collisionLayer;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius;
    private bool isGrounded;
    private bool isJumping;

    // Start is called before the first frame update
    private void Start()
    {
      body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
      isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayer);
      body.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, body.velocity.y);

      if (Input.GetKey(KeyCode.Space) && isGrounded) {
        isJumping = true;
        body.velocity = new Vector2(body.velocity.x, jumpForce);
        isJumping = false;
      }
    }
}
