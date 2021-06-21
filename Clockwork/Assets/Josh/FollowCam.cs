using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 offset;  // set to (0,5,-7)
    public Camera camera;
    // public positions for testing
   
   
 
    void LateUpdate()
    {
        camera.transform.position = transform.position + transform.TransformDirection(offset);
        camera.transform.rotation = transform.rotation;

    }
}
