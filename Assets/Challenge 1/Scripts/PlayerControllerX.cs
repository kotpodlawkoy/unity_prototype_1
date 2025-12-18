using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    private float _alignPlane ( float rotationAngle )
    {
        //Debug.Log ( )
        if ( rotationAngle != 0 )
        {
            return Mathf.Min ( Mathf.Abs ( rotationAngle ), Mathf.Abs ( rotationSpeed * Time.deltaTime ) ) ;
        }
        return 0.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical_1");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, verticalInput * rotationSpeed * Time.deltaTime);
    }

    void LateUpdate()
    {
        Quaternion qua = new ( transform.rotation.x, 0.0f, 0.0f, transform.rotation.w );
        transform.SetPositionAndRotation ( transform.position, qua );
    }
}
