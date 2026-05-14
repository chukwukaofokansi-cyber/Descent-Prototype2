using TMPro; // Code by Kieran (AI overview example followed)
using UnityEngine;

public class ShowTextOnTouch : MonoBehaviour
{
    public GameObject textObject;

    void Start()
    {
        textObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.SetActive(false);
        }
    }
}

