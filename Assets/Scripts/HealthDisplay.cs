using UnityEngine; // Code by Kieran
using UnityEngine.UI;   

public class HealthDisplay : MonoBehaviour
{
    public int health; // This variable keeps track of the player's current health, which will be used to determine how many heart icons should be displayed as full or empty on the screen
    public int maxHealth; // This variable represents the maximum health that the player can have, which will be used to determine how many heart icons should be enabled or disabled on the screen based on the player's current health

    public Sprite emptyHeart; // This variable is a reference to a Sprite that represents an empty heart icon, which will be used to visually indicate when the player has lost health
    public Sprite fullHeart; // This variable is a reference to a Sprite that represents a full heart icon, which will be used to visually indicate when the player has full health or has not lost any health
    public Image[] hearts; // This variable is an array of Image components that represent the heart icons on the screen, which will be updated based on the player's current health and maximum health to visually display the player's health status

    public PlayerHealth playerHealth; // This variable is a reference to the PlayerHealth script, which is likely responsible for managing the player's health and providing the current health and maximum health values that will be used to update the heart icons on the screen

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = playerHealth.health; // This line assigns the current health value from the PlayerHealth script to the local variable 'health', which will be used to determine how many heart icons should be displayed as full or empty on the screen
        maxHealth = playerHealth.maxHealth; // This line assigns the maximum health value from the PlayerHealth script to the local variable 'maxHealth', which will be used to determine how many heart icons should be enabled or disabled on the screen based on the player's current health

        for (int i = 0; i < hearts.Length; i++) // This loop iterates through each Image component in the 'hearts' array, allowing the script to update the heart icons on the screen based on the player's current health and maximum health
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart; // If the current index is less than the player's current health, set the heart icon to the full heart sprite
            }
            else
            {
                hearts[i].sprite = emptyHeart; // If the current index is greater than or equal to the player's current health, set the heart icon to the empty heart sprite    
            }

            if (i < maxHealth)
            {
                hearts[i].enabled = true; // If the current index is less than the player's maximum health, enable the heart icon to be visible on the screen
            }
            else
            {
                hearts[i].enabled = false; // If the current index is greater than or equal to the player's maximum health, disable the heart icon to hide it from the screen
            }
        }   
    }
}
