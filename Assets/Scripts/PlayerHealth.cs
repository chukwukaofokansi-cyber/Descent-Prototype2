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

    
    public void TakeDamage(int amount) // This method is called to reduce the player's health by a specified amount, and it also checks if the player's health has reached zero or below, in which case it disables the player's sprite renderer and movement components to visually indicate that the player has died
    {
        health -= amount; // This line subtracts the specified amount from the player's current health, effectively reducing the player's health by that amount
        if (health <= 0) 
        {
            playerSr.enabled = false; // Disable the player's sprite renderer component to make the player invisible in the scene, visually indicating that the player has died
            playerMovement.enabled = false; // Disable the player's movement component to prevent the player from moving in the scene, further reinforcing the visual indication that the player has died

        }
    }
}
