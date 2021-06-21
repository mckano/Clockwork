using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float smoothspeed = 0.120f;
    public Vector3 offsetCamera;

    // Start is called before the first frame update
    void FixedUpdate ()
    {
        Vector3 desiredPosition = player.position + offsetCamera;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        transform.position = smoothPosition;
        transform.LookAt(player);
    }
}
