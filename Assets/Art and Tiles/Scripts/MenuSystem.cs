using UnityEngine; //Greg
using UnityEngine.SceneManagement;
public class MenuSystem : MonoBehaviour
{

public void OnStartClick()// this loads the specific scene when startbutton is pressed
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void OnGodModeClick()// this loads the specific scene when startbutton is pressed
    {
        SceneManager.LoadScene("Level 3 Godmode");
    }

    public void OnCreditClick()// this loads the specific scene when the credit button is clicked
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnHelpClick()// this loads the specific scene when the the help button is clicked
    {
        SceneManager.LoadScene("Help");
    }

    public void OnReturnClick()// this returns to main menu when clicked
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnExitClick() // this closed the application when used in unity and or its on load
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }
    // GDT
}
