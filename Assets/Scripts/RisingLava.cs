using UnityEngine; // Code by Kieran

public class RisingLava : MonoBehaviour
{
    public float riseSpeed = 1f; // Speed at which the lava rises
    public bool isRising = false; // Flag to control whether the lava should rise or not

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRising)
        {
            transform.Translate(Vector3.up * riseSpeed * Time.deltaTime); // Move the lava upwards at a speed defined by riseSpeed, multiplied by Time.deltaTime to ensure smooth movement regardless of frame rate
        }
    }
}
