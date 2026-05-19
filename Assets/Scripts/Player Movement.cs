using UnityEngine; // Chukwuka (Coyote Time Code by Kieran)

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rb2d;
    public float movespeed;
    public float jump = 15f;
    private float InputHorizontalLeft;

    private float coyoteTime = 0.2f;// Coyote time is a game design technique that allows players to jump for a short period of time after leaving a platform, giving them a small window of opportunity to still perform a jump even if they are not technically grounded. This can make the game feel more responsive and forgiving.
    private float coyoteTimeCounter; // CoyoteTimeCounter keeps track of how much time has passed since the player was last grounded. 

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundlayer;

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



    }
        
    
   


    private void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(InputHorizontalLeft * movespeed, rb2d.linearVelocityY);
    }
}
