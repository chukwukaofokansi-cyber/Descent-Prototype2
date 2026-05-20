using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rb2d;
    public float movespeed;
    public float jump = 15f;
    private float InputHorizontalLeft;

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
        InputHorizontalLeft = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && Grounded())
        {
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, jump));
        }

        else if (Input.GetButtonUp("Jump") && rb2d.linearVelocity.y > 0f)
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocityX, rb2d.linearVelocityY * 0.5f);
        }


    }
        
    
   


    private void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(InputHorizontalLeft * movespeed, rb2d.linearVelocityY);
    }
}
