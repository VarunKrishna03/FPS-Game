using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousehorizontal = Input.GetAxis("Mouse X");
        float mousevertical = Input.GetAxis("Mouse Y");
        transform.rotation = transform.rotation * Quaternion.Euler(0, mousehorizontal, 0);
        Camera cam = GetComponentInChildren<Camera>();
        cam.transform.localRotation = Quaternion.Euler(-mousevertical, 0, 0) * cam.transform.localRotation;
        
    }
}
