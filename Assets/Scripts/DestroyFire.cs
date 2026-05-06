using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyFire : MonoBehaviour
{
    private void Awake()
    {
        {
            StartCoroutine(waiter());// this is a coroutine that will wait a certain amount of time before destroying the fire object
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }// this is the function that will wait for 0.5 seconds before destroying the fire object
}// GDT
