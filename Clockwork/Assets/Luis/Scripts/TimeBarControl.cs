using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarControl : MonoBehaviour
{
    public Image timeSlider;
    public float maxTime;
    public float currentTime;
    float reduceTimeBy = 1f;

    private void Start()
    {
        currentTime = maxTime;
    }

    private void Update()
    {
        timeSlider.fillAmount = currentTime / maxTime;

        if (currentTime > 0)
        {
            if(Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.Z)|| Input.GetKey(KeyCode.X))
            {
                ReduceTimeBar();
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                SubstractTimeBar(reduceTimeBy);
            }
        }
    }

    public void ReduceTimeBar()
    {
        currentTime -= Time.deltaTime;
    }

    public void SubstractTimeBar(float minusTime)
    {
        currentTime -= minusTime;
    }
}
