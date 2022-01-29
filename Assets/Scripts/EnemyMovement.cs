using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  private Rigidbody2D body;
  [SerializeField] private LayerMask collisionLayer;
  [SerializeField] private float moveSpeed = 5;
  [SerializeField] private float jumpForce = 5;
  [SerializeField] private bool isGoingRight = false;
  [SerializeField] private float raycastingDistance = 1f;
  private Vector3 direction;
  private bool isJumping;

  // Start is called before the first frame update
  private void Start()
  {
    body = GetComponent<Rigidbody2D>();
    
    if (isGoingRight)
      direction = transform.right;
    else
      direction = -transform.right;
  }

  private bool isGrounded()
  {
    RaycastHit2D ground = Physics2D.Raycast(transform.position, Vector2.down, raycastingDistance, collisionLayer);

    if (ground.collider != null)
      return true;
    return false;
  }

  private bool isBlocked()
  {
    RaycastHit2D hit = Physics2D.Raycast(transform.position + direction * raycastingDistance - new Vector3(0f, 0.25f, 0f), direction, 0.075f);

    if (hit.collider != null)
      if (hit.transform.tag == "Terrain")
        return true;
    return false;
  }

  // Update is called once per frame
  private void Update()
  {
    if (isBlocked() || !isGrounded())
      direction = -direction;

    transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
  }
}
