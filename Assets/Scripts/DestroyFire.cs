using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DestroyFire : MonoBehaviour
{
    private void Awake()
    {
        {
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
