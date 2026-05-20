using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Respawn : MonoBehaviour
{

    private Checkpoint Respawning;
    private BoxCollider2D collide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        collide = GetComponent<BoxCollider2D>();
        Respawning = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Checkpoint>();
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
