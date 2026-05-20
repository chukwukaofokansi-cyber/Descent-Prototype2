using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    private bool Level1Achievement = false;
    private bool Level2Achievement = false;
    private bool Level3Achievement = false;
    private bool Level4Achievement = false;
    private bool TutorialAchievement = false;

    public Image[] achievements;
    public Sprite Locked;
    public Sprite Level1;
    public Sprite Level2;   
    public Sprite Level3;
    public Sprite Level4;
    public Sprite Tutorial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < achievements.Length; i++)
        {
            if (achievements[0] == false)
            {
                achievements[i].sprite = Locked;
            }
            else
            {
                achievements[0].sprite = Level1;
            }
        }
    }
}
