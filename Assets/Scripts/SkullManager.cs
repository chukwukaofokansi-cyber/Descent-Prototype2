using TMPro;
using UnityEngine;

public class SkullManager : MonoBehaviour
{
    public int totalSkulls;
    public TMP_Text Skull_Text;
    public static SkullManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        void Start()
        {
            totalSkulls = 0;
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial")
            {
                Skull_Text.text = "Skulls: " + totalSkulls + "/1";
            }
            else
            {
                Skull_Text.text = "Skulls: " + totalSkulls + "/3";
            }
        }
    }
    public void changeSkulls(int amount)
    {
        totalSkulls += amount;
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Tutorial")
        {
            Skull_Text.text = "Skulls: " + totalSkulls + "/1";
        }
        else
        {
            Skull_Text.text = "Skulls: " + totalSkulls + "/3";
        }
    }
}
