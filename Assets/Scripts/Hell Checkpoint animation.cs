using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEditor.U2D.Aseprite;
public class HellCheckpointanimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Animator animation;

    void Start()
    {
        animation = GetComponent<Animator>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animation.Play("CheckPoint Active animation");

            
        }
    }




}
