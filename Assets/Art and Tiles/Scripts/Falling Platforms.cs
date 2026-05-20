using System.Collections.Generic; // Chukwuka
using System.Collections;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float fallDelay = 0.5f;
    private float DestroyDelay = 2f;

    [SerializeField] private Rigidbody2D platform;
    [SerializeField] private Animator falling;
    [SerializeField] private string fallName = "Rumble Animation";

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            falling.Play("Rumble Animation");
            StartCoroutine(Fall());
        }
    }


    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        platform.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, DestroyDelay);
           

    }
        




}
