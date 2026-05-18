using Unity.VisualScripting;
using UnityEngine; //Greg

public class SceneController : MonoBehaviour
{
    public int currentSceneIndex;
    public static SceneController instance;
    public PlayerHealth playerHealth;

    private void Awake()
    {
        if (instance == null) // Check if the instance variable is null, meaning that no SceneController instance has been assigned yet
        {
            instance = this; // If the instance variable is null, assign the current instance of the SceneController script to it
            DontDestroyOnLoad(gameObject); // This line ensures that the SceneController GameObject is not destroyed when loading a new scene, allowing it to persist across different scenes in the game
        }
        else
        {
            Destroy(gameObject); // If the instance variable is not null, meaning that another SceneController instance already exists, destroy the current GameObject to prevent multiple instances of the SceneController from existing in the scene
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
      

       if (other.CompareTag("Player"))// Grabs the player tag to know what to collide with and then changes the scene when the player collides with it
        {
          
            currentSceneIndex++;// Increases the scene index by 1 to load the next scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex);// Loads the scene based on the current scene index
        }
    }

   private void Update() //Kieran
    {
        if (playerHealth.health <= 0) // Checks if the player's health is less than or equal to zero, which indicates that the player has died
        {
            currentSceneIndex = 0; // Resets the current scene index to 0, which typically corresponds to the first scene in the game
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex); // Loads the scene based on the reset current scene index, effectively restarting the game from the beginning
        }

    } //Kieran end

}// GDT
