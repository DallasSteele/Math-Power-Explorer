using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A simple 2D movement controller for a player in Unity
public class PlayerMovement : MonoBehaviour
{
    private bool canMove = true; //variabel added to control movement
    #region Gameplay properties
    private float playerInput = 0;

    // Horizontal player speed
    [SerializeField] private float speed = 250;

    #endregion

    #region Component references

    private Rigidbody2D rb;

    #endregion

    #region Initialisation methods

    // Initialises this component
    // (NB: Is called automatically before the first frame update)
    void Start()
    {
        // Get component references
        rb = GetComponent<Rigidbody2D>();
    }

    #endregion

    #region Gameplay methods

    // Is called automatically every graphics frame
    void Update()
    {
         if (!canMove)
            return;  // If canMove is false, do not process movement

        // Detect and store horizontal player input   
        playerInput = Input.GetAxisRaw("Horizontal");

        // NB: Here, you might want to set the player's animation,
        // e.g. idle or walking

        // Swap the player sprite scale to face the movement direction
        SwapSprite();
    }

        public void SetCanMove(bool canMove = true)
    {
        this.canMove = canMove;
    }

    // Swap the player sprite scale to face the movement direction
    void SwapSprite()
    {
        // Right
        if (playerInput > 0)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x),
                transform.localScale.y,
                transform.localScale.z
            );
        }
        // Left
        else if (playerInput < 0)
        {
            transform.localScale = new Vector3(
                -1 * Mathf.Abs(transform.localScale.x),
                transform.localScale.y,
                transform.localScale.z
            );
        }
    }

    // Is called automatically every physics step
    void FixedUpdate()
    {
        // Move the player horizontally
        rb.velocity = new Vector2(
            playerInput * speed * Time.fixedDeltaTime,
            0
        );
    }

    #endregion
}





/*
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float speed = 1.5f;

    private Animator animator;
    private bool isFacingRight = true;  // Added this line
    private Rigidbody2D rb;
    private Vector3 initialPosition;  // Store the initial position

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        initialPosition = transform.position;  // Store the initial position at start
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        Debug.Log("Horizontal input: " + horizontal);

        Flip();
    }

    public void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        Debug.Log("Velocity: " + rb.velocity);
    }

    public void Flip()
    {
        if ((horizontal > 0 && !isFacingRight) || (horizontal < 0 && isFacingRight))
        {
            isFacingRight = !isFacingRight;
            animator.SetBool("IsFacingRight", isFacingRight);
        }
    }

    // Function to reset the position after animation
    public void ResetPosition()
    {
        transform.position = initialPosition;
    }
}*/






