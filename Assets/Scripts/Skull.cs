using UnityEngine; //Code by Kieran

public class NewMonoBehaviourScript : MonoBehaviour
{
    public SkullManager skullManager; // Reference to the SkullManager script
    public void OnTriggerEnter2D(Collider2D collision) // This method is called when another collider enters the trigger collider attached to the same GameObject as this script
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the colliding object has the tag "Player"
        {
            SkullManager.instance.changeSkulls(1); // Call the changeSkulls method on the SkullManager instance, passing in 1 to indicate that one skull should be added
            Destroy(gameObject); //  Destroy the GameObject that this script is attached to, effectively removing the skull from the scene
        }
    }
}

