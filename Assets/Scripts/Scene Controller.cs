using UnityEngine;

public class SceneController : MonoBehaviour
{
  public int currentSceneIndex;

  
    private void OnTriggerEnter2D(Collider2D other)
    {
      

       if (other.CompareTag("Player"))// Grabs the player tag to know what to collide with and then changes the scene when the player collides with it
        {
          
            currentSceneIndex++;// Increases the scene index by 1 to load the next scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneIndex);// Loads the scene based on the current scene index
        }
    }
}// GDT
