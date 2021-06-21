using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePoint 
{
    public Vector3 position;
    public Quaternion rotation;

    public TimePoint (Vector3 _position, Quaternion _rotation)
    {
        position = _position;
        rotation = _rotation;

    }
}
