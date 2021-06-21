using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTests : MonoBehaviour
{
    Rigidbody rb;
    int layer;
    float rayLength;

    public float moveSpeed;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        layer = LayerMask.GetMask("Floor");
        rayLength = transform.localScale.y / 2;
    }

    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime;
        float zMove = Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime;

        rb.velocity = new Vector3(xMove * moveSpeed, rb.velocity.y, zMove * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), rayLength, layer))
            {
                rb.AddForce(rb.velocity.x, jumpForce, rb.velocity.z);
            }
        }

    }
 
}
