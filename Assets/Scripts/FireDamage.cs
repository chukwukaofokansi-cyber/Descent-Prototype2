using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public int damage = 1;

    private Transform respawnPoint;

    private void Start()
    {
        respawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform; // This gets the tag for anything undfer the respawn point
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Gets the direct tag for anying under Player
        {
            PlayerHealth health = other.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }

            other.transform.position = respawnPoint.position;
        }
    }
}// This is working with other health system  scripts and has some simularities with the respawn script but was made by GDT