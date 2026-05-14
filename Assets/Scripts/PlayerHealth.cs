using UnityEngine; // Code by Kieran

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 3;
    
    public HealthDisplay healthDisplay;
    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0) 
        {
            playerSr.enabled = false;
            playerMovement.enabled = false;
            
        }
    }
}
