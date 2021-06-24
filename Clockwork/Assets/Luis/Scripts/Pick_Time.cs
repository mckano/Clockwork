using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Time : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        MovementTests moveScript = other.GetComponent<MovementTests>();

        if(moveScript != null)
        {
            moveScript.timeBar.currentTime += 2f;
            if (moveScript.timeBar.currentTime > 5f)
                moveScript.timeBar.currentTime = 5;
        }
        Destroy(gameObject);
    }
}
