using TMPro; // Code by Kieran
using UnityEngine;

public class SkullManager : MonoBehaviour
{
    public int totalSkulls; // This variable keeps track of the total number of skulls collected by the player
    public TMP_Text Skull_Text; // This variable is a reference to a TextMeshPro text component that will display the number of skulls collected on the screen
    public static SkullManager instance; // This variable is a static reference to the SkullManager instance, allowing other scripts to access it without needing a direct reference
    private void Awake()
    {
        if (instance == null) // Check if the instance variable is null, meaning that no SkullManager instance has been assigned yet
        {
            instance = this; // If the instance variable is null, assign the current instance of the SkullManager script to it
             DontDestroyOnLoad(gameObject); // This line ensures that the SkullManager GameObject is not destroyed when loading a new scene, allowing it to persist across different scenes in the game
        }
        else
        {
            Destroy(gameObject); // If the instance variable is not null, meaning that another SkullManager instance already exists, destroy the current GameObject to prevent multiple instances of the SkullManager from existing in the scene
        }

        void Start()
        {
            totalSkulls = 0; // Initialize the totalSkulls variable to 0 at the start of the game
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial") // Check if the current active scene is named "Tutorial"
            {
                Skull_Text.text = "Skulls: " + totalSkulls + "/1"; // If the current active scene is "Tutorial", set the text of the Skull_Text component to display the number of skulls collected out of 1
            }
            else
            {
                Skull_Text.text = "Skulls: " + totalSkulls + "/3"; // If the current active scene is not "Tutorial", set the text of the Skull_Text component to display the number of skulls collected out of 3
            }
        }
    }
    public void changeSkulls(int amount) 
    {
        totalSkulls += amount; // This line adds the specified amount to the totalSkulls variable, allowing other scripts to update the number of skulls collected by calling this method with the appropriate amount
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial") // Check if the current active scene is named "Tutorial"
        {
            Skull_Text.text = "Skulls: " + totalSkulls + "/1"; // If the current active scene is "Tutorial", update the text of the Skull_Text component to display the updated number of skulls collected out of 1
        }
        else
        {
            Skull_Text.text = "Skulls: " + totalSkulls + "/3"; // If the current active scene is not "Tutorial", update the text of the Skull_Text component to display the updated number of skulls collected out of 3
        }
    }
}
