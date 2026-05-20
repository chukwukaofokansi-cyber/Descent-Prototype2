using UnityEngine; //Code by Chukwuka
using System.Collections.Generic;
using System.Collections;

public class TheCheckPointScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private ObstacleDamage Obstacle;
    private TheRespawnScript Respawning;
    private BoxCollider2D collide;
    private BoxCollider2D ObstacleCollide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        collide = GetComponent<BoxCollider2D>();
        //Respawning = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TheRespawnScript>();
    }


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("something just hit us");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("player has hit checkpoint!!");
            other.GetComponent<PlayerRespawn>().UpdateCheckPoint(transform.position);    
            //Respawning.respawnPoint = this.gameObject;
            collide.enabled = false;
        }
    }
}
