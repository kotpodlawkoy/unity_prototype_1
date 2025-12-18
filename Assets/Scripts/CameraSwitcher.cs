using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject additionalCamera;
    public KeyCode switchKey;
    bool isMainCamera = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        additionalCamera.SetActive ( false );
    }

    // Update is called once per frame
    void Update()
    {
       if ( Input.GetKeyDown ( switchKey ) )
       {
           mainCamera.SetActive ( !isMainCamera );
           additionalCamera.SetActive ( isMainCamera );
           isMainCamera = !isMainCamera;
       } 
    }
}
