using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementTest : MonoBehaviour
{
    public Vector3 pointB;
    public float speedP;
    private float defaultSpeed = 16f;
    IEnumerator Start()
    {
       
        var pointA = transform.position;
        while (true)
        {

            yield return StartCoroutine(MoveObject(transform, pointA, pointB, speedP));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, speedP));
        }
    }
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
       
      //  if (Input.GetKeyDown(KeyCode.Z))
      //  {
      //      speedP = 70.0f;
    //    }
      //  else if (Input.GetKeyUp(KeyCode.Z))
      //  {
        //    speedP = defaultSpeed;
       // }
    }
    private void OnTriggerEnter(Collider collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.transform.parent = null;
        }
    }
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 4.0f / time;
        while (i < 1.0f)
        {
            rate = 4.0f / time;
            // controll the speed of object with movement using Z to speed up and X to slow down
            if (Input.GetKey(KeyCode.Z))
            {
                rate = 20.0f / time;
            }
           
            if (Input.GetKey(KeyCode.X))
            {
                rate = 1.0f / time;
            }
           

            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;

            rate = 3.0f;
        }
    }
      
}
