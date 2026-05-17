using UnityEngine; // Code by Kieran

public class LavaSpeedUp : MonoBehaviour
{
    public RisingLava lava;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            lava.riseSpeed *= 2.2f; // Increase the rise speed of the lava by 0.5 when the player enters the trigger
        }
    }
}
