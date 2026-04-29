using Unity.VisualScripting;
using UnityEngine;

public class Bounce : MonoBehaviour
{
float bounceForce = 10f;

    private void OnTriggerEnter2D(Collider2D collision) // This will check for when the player mkaes contact tith the bounce object and then will trigger the function to commence 
    {
     if (collision.CompareTag("Player"))
        {
            HandlePlayerBounce(collision.gameObject);
        }
    }

    private void HandlePlayerBounce(GameObject player)
    {
         Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if(rb)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);// this tags the value that wil be cjhanged when the bounce is triggered

            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);// this is what actually applies the boun ce force to the player when triggered
        }
    }
}// GDT
