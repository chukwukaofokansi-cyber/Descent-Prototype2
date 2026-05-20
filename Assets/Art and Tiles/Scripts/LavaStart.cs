using UnityEngine; // Code by Kieran

public class StartLava : MonoBehaviour
{
    public RisingLava lava;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            lava.isRising = true;
            lava.enabled = true;
        }
    }
}
