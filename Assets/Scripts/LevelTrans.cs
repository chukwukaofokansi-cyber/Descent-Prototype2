
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelTrans : MonoBehaviour
{

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}

