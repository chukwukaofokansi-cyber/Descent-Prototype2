using UnityEngine; // Chukwuka
using System.Collections.Generic;
using System.Collections;

public class TheRespawnScript : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //public GameObject Player;
    //public GameObject respawnPoint;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerRespawn>().RespanwNew();
            //Player.transform.position = respawnPoint.transform.position;
            playerHealth.TakeDamage(damage);
        }
    }
}
