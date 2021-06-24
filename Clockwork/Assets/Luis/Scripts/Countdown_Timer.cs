using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Timer : MonoBehaviour
{

    public Text timerText;
    public float remainingTime;
    bool countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = true;
        remainingTime += 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (countdown)
        {
            if(remainingTime > 0f)
            {
                remainingTime -= Time.deltaTime;
            }
            else
            {
                remainingTime = 0f;
                countdown = !countdown;
                //you can add here the line to load a different scene, or whatever happens once the countdown ends.
            }
        }
        //this line divides the remaining time by 60 returning a rounded number to the minutes
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        //this line shows the remaining seconds that don't complete a full '60'
        float seconds = Mathf.FloorToInt(remainingTime % 60);


        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
