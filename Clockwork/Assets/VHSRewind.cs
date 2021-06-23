using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VHSRewind : MonoBehaviour
{
    public GameObject timeCamera;
    public void CameraVhsOn()
    {
        timeCamera.SetActive(true);
    }
    public void CameraVhsOff()
    {
        timeCamera.SetActive(false);
    }
}
