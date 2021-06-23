using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCanFall : MonoBehaviour
{

    bool isFalling = false;
    float downSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }



    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            isFalling = true;

        }
    }

    private void Update()
    {
        if (isFalling)
        {

            // always increasing speed of platform to not be different for different fps
            downSpeed += Time.deltaTime / 10;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);

        }
    }

}