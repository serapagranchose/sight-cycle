using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private LayerMask collisionLayer;
    [SerializeField] private float moveSpeed = 10;
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private float raycastingDistance = 1f;
    private Vector3 direction;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private bool isGrounded()
    {
      RaycastHit2D ground = Physics2D.Raycast(transform.position, Vector2.down, raycastingDistance, collisionLayer);

      if (ground.collider != null)
        return true;
      return false;
    }

    private bool isBlocked(float velocity)
    {
      if (velocity > 0.1f)
        direction = Vector3.right;
      else if (velocity < -0.1f)
        direction = Vector3.left;

      RaycastHit2D hit = Physics2D.Raycast(transform.position + direction * raycastingDistance - new Vector3(0f, 0.25f, 0f), direction, 0.075f);

      if (hit.collider != null)
        if (hit.transform.tag == "Ground")
          return true;
      return false;
    }

    // Update is called once per frame
    private void Update()
    {
      float velocity = Input.GetAxis("Horizontal") * moveSpeed;

      if (!isBlocked(velocity)) {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, body.velocity.y);
      }

      if (Input.GetKey(KeyCode.Space) && isGrounded()) {
        body.velocity = new Vector2(body.velocity.x, jumpForce);
      }

      float characterVelocity = Mathf.Abs(velocity);
      animator.SetFloat("Speed", characterVelocity);
      Flip(velocity);

      if (isGrounded())
      {
          animator.SetBool("isJumping", false);
      }
      else
      {
          animator.SetBool("isJumping", true);
      }
    }

    void Flip(float velocity)
    {
        if (velocity  > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if(velocity  < -0.1f)
        {
            spriteRenderer.flipX = true;
        }

    }

}
