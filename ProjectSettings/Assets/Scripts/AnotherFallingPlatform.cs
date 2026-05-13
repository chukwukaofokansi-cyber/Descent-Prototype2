using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Events;
public class AnotherFallingPlatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Custom Event")]
    public UnityEvent myEvents; 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (myEvents == null)
        {
            print("My event is null");
        }
        else
        {
            print("EventActivated");
        }

    }

    
    
}
