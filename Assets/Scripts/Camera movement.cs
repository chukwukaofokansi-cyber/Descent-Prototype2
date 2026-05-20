using UnityEngine; //Chukwuka

public class Cameramovement : MonoBehaviour
{

    private Vector3 offset = new Vector3(0f, 0f, -10f);// set the offset using vector3 to get the x, y, z position in scene 
    private float smoothTime = 0.30f; // this will be used to et how smooth the camera follows the target.
    private Vector3 Velocity = Vector3.zero;// how fast the camera will move based on velocity in the x and y position 

    [SerializeField] private Transform target; //A private field that is used  in unity that will get a gameObject Transorm position in unity 

    //Start is called once before the first execution of Update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset; //variable targetPosition has the targets transform and position in scene merged with the offset of the camera 
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref Velocity, smoothTime);   //
    }
}
