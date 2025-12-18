using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    public float tHold = 500.0f;
    public float spinAcceleration = 1.0f;

    private float spinVelocity = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void accellerateSpinning ( ref float velocity )
    {
        if ( velocity < tHold )
        {
            velocity = velocity + spinAcceleration;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        accellerateSpinning ( ref spinVelocity );
        transform.Rotate ( Vector3.forward, spinVelocity * Time.deltaTime );
    }
}
