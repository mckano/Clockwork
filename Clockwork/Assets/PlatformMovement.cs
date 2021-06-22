using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Vector3 pointB;
    public float speedP;

    IEnumerator Start()
    {
        speedP = 3.0f;
        var pointA = transform.position;
        while (true)
        {
           
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, speedP));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, speedP));
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            speedP = 30.0f;
        }
      
      
      
    }
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 3.0f / time;
        while (i < 1.0f)
        {
            
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
           
           

        }
       
        
    }
}
