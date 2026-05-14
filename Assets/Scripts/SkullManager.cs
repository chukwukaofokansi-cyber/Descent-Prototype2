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
                Skull_Text.text = "Skulls: " + totalSkulls + "/3";
            }
    }
    public void changeSkulls(int amount)
    {
        totalSkulls += amount;
        Skull_Text.text = "Skulls: " + totalSkulls + "/3";
    }
}
