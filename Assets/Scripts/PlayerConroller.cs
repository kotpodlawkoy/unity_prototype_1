using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Speed;
    public float TurnSpeed;
    public string axisHorizontal;
    public string axisVertical;
    private float horizontalInput, forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis ( axisHorizontal );
        forwardInput = Input.GetAxis ( axisVertical );

        transform.Translate ( Vector3.forward * forwardInput * Speed * Time.deltaTime );
        transform.Rotate ( Vector3.up, TurnSpeed * horizontalInput * Time.deltaTime );
    }
}
