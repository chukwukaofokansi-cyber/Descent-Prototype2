using JetBrains.Annotations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Achievements : MonoBehaviour
{

    public SceneController sceneController;
    public SkullManager skullManager;
    public List<Achievement> achievements;

    public int Tutorial;
    public int Level1;
    public int Level2;
    public int Level3;
    public int Level4;

    public bool AchievementUnlocked(string achievementName)
    {
        bool result = false;

        if (achievements == null)
        {
            return false;
        }

        Achievement[] achievementArray = achievements.ToArray();
        Achievement a = Array.Find(achievementArray, ach => achievementName == ach.title);

        if (a == null)
        {
            return false;
        }

        result = a.achieved;

        return result;
    }

    private void Start()
    {
        InitializeAchievements();
    }

    private void InitializeAchievements()
    {
        if (achievements != null)
        {
            return;
        }
        achievements = new List<Achievement>();
        achievements.Add(new Achievement("Baby Steps", "Finish the Tutorial Level", (object o) => Tutorial == 1));
        achievements.Add(new Achievement("Level 4 Completed", "Finish Level 4", (object o) => Level4 == 1));
        achievements.Add(new Achievement("Level 2 Completed", "Finish Level 2", (object o) => Level2 == 1));
        achievements.Add(new Achievement("Level 3 Completed", "Finish Level 3", (object o) => Level3 == 1));
        achievements.Add(new Achievement("What's This?", "Collect a Skull", (object o) => SkullManager.instance.totalSkulls >= 1));
    }

    private void Update()
    {
        CheckAchievementCompletion();

    }

    private void CheckAchievementCompletion()
    {
        foreach (var achievement in achievements)
        {
            achievement.UpdateCompletion();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && sceneController.currentSceneIndex == 3)
        {
            Tutorial = 1;
        }

        if (collision.CompareTag("Player") && sceneController.currentSceneIndex == 6)
        {
            Level4 = 1;
        }

        if (collision.CompareTag("Player") && sceneController.currentSceneIndex == 4)
        {
            Level2 = 1;
        }

        if (collision.CompareTag("Player") && sceneController.currentSceneIndex == 5)
        {
            Level3 = 4;
        }
    }
}

public class Achievement
{
    public Achievement(string title, string description, Predicate<object> requirement)
    {
        this.title = title;
        this.description = description;
        this.requirement = requirement;
    }

    public string title;
    public string description;
    public Predicate<object> requirement;

    public bool achieved;

    public void UpdateCompletion()
    {
        if (achieved)
        {
            return;
        }

        if (RequirementsMet())
        {
            Debug.Log($"{title}: {description}");
            achieved = true;
        }
    }

    public bool RequirementsMet()
    {
        return requirement.Invoke(null);
    }
}