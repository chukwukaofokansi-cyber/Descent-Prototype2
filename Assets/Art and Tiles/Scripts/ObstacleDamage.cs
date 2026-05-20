using UnityEngine; //Code by Kieran

public class ObstacleDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) // This method is called when the GameObject this script is attached to collides with another GameObject
    {
        if (collision.gameObject.tag == "Player") // Check if the colliding GameObject has the tag "Player"
        {
            playerHealth.TakeDamage(damage); // If the colliding GameObject is the player, call the TakeDamage method on the playerHealth reference, passing in the damage value to reduce the player's health accordingly
        }
    }
}
