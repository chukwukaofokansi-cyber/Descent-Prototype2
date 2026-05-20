using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine; // Chukwuka (Coyote Time Code by Kieran)

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rb2d;
    public float movespeed;
    public float jump = 15f;
    private float InputHorizontalLeft;

    public static PlayerMovement instance;
    private bool canDash = false;
    private bool isDashing;
    private float dashingPower = 15f;
    private float dashingTime = 0.3f;
    private float dashingCooldown = 1f;
    private bool FacingRight = true;
    

    private float coyoteTime = 0.2f;// Coyote time is a game design technique that allows players to jump for a short period of time after leaving a platform, giving them a small window of opportunity to still perform a jump even if they are not technically grounded. This can make the game feel more responsive and forgiving.
    private float coyoteTimeCounter; // CoyoteTimeCounter keeps track of how much time has passed since the player was last grounded. 

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;
    [SerializeField] private TrailRenderer Trail;

    Vector2 MoveDirection; 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

       
    }

    private bool Grounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }

    // Update is called once per frame
    void Update()
    {

        if (isDashing) {
            return;
        }

        if (Grounded())
        {
            coyoteTimeCounter = coyoteTime; //Coyototimer counter is set to the coyote time when the player is grounded, allowing them to jump for a short period once they are not grounded

        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime; // If the player is not grounded, the coyote time counter decreases by the time that has passed since the last frame, eventually reaching zero and preventing the player from jumping until they are grounded again
        }

   


        InputHorizontalLeft = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump")  && coyoteTimeCounter > 0f) // If the player presses the jump button and the coyote time counter is greater than zero, allowing them to jump even if they are not currently grounded, as long as they have recently been grounded within the coyote time window
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jump));
          
        }

        else if (Input.GetButtonUp("Jump") && rb2d.linearVelocity.y > 0f)
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocityX, rb2d.linearVelocityY * 0.5f);
            coyoteTimeCounter = 0f; // the coyote time counter is reset to zero, preventing the player from jumping again until they are grounded again

        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash) 
        {
            StartCoroutine(Dash());   
        }

        Flip();

    }
        
    
   


    private void FixedUpdate()
    {

        if (isDashing)
        {
            return; 
        }
        rb2d.linearVelocity = new Vector2(InputHorizontalLeft * movespeed, rb2d.linearVelocityY);
    }

    private void Flip()
    {
        if (FacingRight && InputHorizontalLeft < 0f || !FacingRight && InputHorizontalLeft > 0f)
        {
            Vector3 LocalScale = transform.localScale;
            FacingRight = !FacingRight;
            LocalScale.x *= -1f;
            transform.localScale = LocalScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.CompareTag("Dashboots"))
        {
            canDash = true;
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb2d.gravityScale;
        rb2d.gravityScale = 0f;
        rb2d.linearVelocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        Trail.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        rb2d.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
