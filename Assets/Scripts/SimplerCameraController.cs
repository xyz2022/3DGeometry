using UnityEngine;



public class SimplerCameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed = 2.5f;

    private float multiplyer;
    private int directionX = 0;
    private int directionZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionX = 0;
        directionZ = 0;
        multiplyer = 1f;

        if (Input.GetKey(KeyCode.A))
        {
            directionX = -1;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            directionX = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            directionZ = -1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            directionZ = 1;
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            multiplyer = 2.0f;
        }
        transform.LookAt(target);
        //transform.Translate(speed * directionX * Vector3.right * Time.deltaTime);
        transform.Translate(new Vector3(speed * multiplyer * directionX * Time.deltaTime, 0, speed * directionZ * Time.deltaTime));
    }
}
