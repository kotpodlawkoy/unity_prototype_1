using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Player;
    private Vector3 offset = new ( 0, 13, -13 );

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
