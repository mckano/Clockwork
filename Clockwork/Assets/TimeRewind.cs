using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRewind : MonoBehaviour
{
    public bool isRewinding = false;
    Rigidbody rb;

    List<TimePoint> timePoints;
    

    // Start is called before the first frame update
    void Start()
    {
        timePoints = new List<TimePoint>();
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Q))
            StopRewind();

    }

    private void FixedUpdate()
    {
        if (isRewinding)
        
            Rewind();
       
        else
        
            Record();
        
          
    }

    void Rewind()
    {

        if (timePoints.Count > 0)
        { 
            TimePoint timePoint = timePoints[0];
            transform.position = timePoint.position;
            transform.rotation = timePoint.rotation;
            timePoints.RemoveAt(0);
        }
        
        else
            StopRewind();
        


    }

    void Record ()
    {
        // checks to see if 5 seconds has elapsed and if so removes items from the list
        if (timePoints.Count >  Mathf.Round(10f / Time.fixedDeltaTime))
        {
            timePoints.RemoveAt(timePoints.Count - 1);
        }
        
        // adds to list
            timePoints.Insert(0, new TimePoint(transform.position, transform.rotation));
        
       
    }

    public void StartRewind()
    {
        isRewinding = true;
        rb.isKinematic = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
        rb.isKinematic = false;
    }
}
