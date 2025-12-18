using UnityEngine;

public class AdditionalCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Player;
    private Vector3 offset = new ( 0.0f, 3.0f, 2.21f );
    private Quaternion rotorOffset = new ();

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = Player.transform.rotation;
        Vector3 projectionOffset = new ( offset.x, 0.0f, offset.z );
        Vector3 forw = new ( Player.transform.forward.x, 0.0f, Player.transform.forward.z );
        float diff_angle = Vector3.SignedAngle ( projectionOffset, forw, Vector3.up );
        Quaternion rotor = Quaternion.AngleAxis ( diff_angle, Vector3.up );
        offset = rotor * offset;
        transform.Rotate ( Vector3.right, 19.0f );
        transform.position = Player.transform.position + offset;
    }
}
