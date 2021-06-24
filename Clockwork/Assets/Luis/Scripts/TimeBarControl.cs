using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarControl : MonoBehaviour
{
    public Image timeSlider;
    public float maxTime;
    public float currentTime;

    private void Start()
    {
        currentTime = maxTime;
    }

    private void Update()
    {

        timeSlider.fillAmount = currentTime / maxTime;
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
