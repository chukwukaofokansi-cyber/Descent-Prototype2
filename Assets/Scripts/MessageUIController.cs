using TMPro; // Code by Kieran (AI overview example followed)
using UnityEngine;

public class ShowTextOnTouch : MonoBehaviour
{
    public GameObject textObject; // Reference to the text object that will be shown when the player touches the trigger

    void Start()
    {
        textObject.SetActive(false); // Ensure the text object is initially hidden when the game starts
    }

    void OnTriggerEnter2D(Collider2D other) // This method is called when another collider enters the trigger collider attached to the same GameObject as this script
    {
        if (other.CompareTag("Player")) // Check if the colliding object has the tag "Player"
        {
            textObject.SetActive(true); // If the colliding object is the player, set the text object to active, making it visible in the scene
        }
    }

    void OnTriggerExit2D(Collider2D other) // This method is called when another collider exits the trigger collider attached to the same GameObject as this script
    {
        if (other.CompareTag("Player")) // Check if the colliding object has the tag "Player"
        {
            textObject.SetActive(false); // If the colliding object is the player, set the text object to inactive, making it invisible in the scene
        }
    }
}

