using UnityEngine; // Code by Kieran (AI assisted)

public class LavaEnd : MonoBehaviour
{
    public RisingLava lava;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            lava.isRising = false;
            lava.enabled = false;
        }
    }
}
