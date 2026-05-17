using UnityEngine; //Code by Chukwuka
using System.Collections.Generic;
using System.Collections;

public class TheCheckPointScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private TheRespawnScript Respawning;
    private BoxCollider2D collide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        collide = GetComponent<BoxCollider2D>();
        Respawning = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TheRespawnScript>();
    }


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Respawning.respawnPoint = this.gameObject;
            collide.enabled = false;
        }
    }
}
