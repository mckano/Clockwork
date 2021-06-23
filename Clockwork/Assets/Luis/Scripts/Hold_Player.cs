using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Player : MonoBehaviour
{
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
}
