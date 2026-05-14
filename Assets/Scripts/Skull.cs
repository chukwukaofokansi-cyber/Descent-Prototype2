using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public SkullManager skullManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SkullManager.instance.changeSkulls(1);
            Destroy(gameObject);
        }
    }
}

