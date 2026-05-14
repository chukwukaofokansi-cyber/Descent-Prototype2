using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSystem : MonoBehaviour
{

public void OnStartClick()
    {
        SceneManager.LoadScene("Kieran");
    }

    public void OnCreditClick()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnHelpClick()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnReturnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }

}
