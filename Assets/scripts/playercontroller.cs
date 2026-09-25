using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private Animator animator;
    private bool isGrounded;
    private Rigidbody2D rb;
    private GameManager GameManager;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        GameManager = FindAnyObjectByType<GameManager>();
    }
    void Start()
    {

    }
    void Update()
    {
        if (GameManager.IsGameOver()) return;
        handleMovement();
        HandleJump();
        UpdateAnimation();
    }
    private void handleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);
        if (moveInput > 0) transform.localScale = new Vector3(1, 1, 1);
        else transform.localScale = new Vector3(-1, 1, 1);
    }
    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Adjust jump force as needed
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

    }
    private void UpdateAnimation()
    {
        bool isRunning = Mathf.Abs(rb.linearVelocity.x) > 0.1f;
        bool isJumping = !isGrounded;
        animator.SetBool("isRunning", isRunning);
        animator.SetBool("isJumping", isJumping);
    }
}